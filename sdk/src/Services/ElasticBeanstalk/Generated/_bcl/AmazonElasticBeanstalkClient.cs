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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ElasticBeanstalk.Model;
using Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations;
using Amazon.ElasticBeanstalk.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.ElasticBeanstalk
{
    /// <summary>
    /// <para>Implementation for accessing ElasticBeanstalk</para>
    ///
    /// AWS Elastic Beanstalk 
    /// <para>
    /// AWS Elastic Beanstalk makes it easy for you to create, deploy, and manage scalable,
    /// fault-tolerant applications running on the Amazon Web Services cloud.
    /// </para>
    ///  
    /// <para>
    /// For more information about this product, go to the <a href="http://aws.amazon.com/elasticbeanstalk/">AWS
    /// Elastic Beanstalk</a> details page. The location of the latest AWS Elastic Beanstalk
    /// WSDL is <a href="https://elasticbeanstalk.s3.amazonaws.com/doc/2010-12-01/AWSElasticBeanstalk.wsdl">https://elasticbeanstalk.s3.amazonaws.com/doc/2010-12-01/AWSElasticBeanstalk.wsdl</a>.
    /// To install the Software Development Kits (SDKs), Integrated Development Environment
    /// (IDE) Toolkits, and command line tools that enable you to access the API, go to <a
    /// href="http://aws.amazon.com/tools/">Tools for Amazon Web Services</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Endpoints</b> 
    /// </para>
    ///  
    /// <para>
    /// For a list of region-specific endpoints that AWS Elastic Beanstalk supports, go to
    /// <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#elasticbeanstalk_region">Regions
    /// and Endpoints</a> in the <i>Amazon Web Services Glossary</i>.
    /// </para>
    /// </summary>
    public partial class AmazonElasticBeanstalkClient : AmazonServiceClient, IAmazonElasticBeanstalk
    {
        private static IServiceMetadata serviceMetadata = new AmazonElasticBeanstalkMetadata();
        private IElasticBeanstalkPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IElasticBeanstalkPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ElasticBeanstalkPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonElasticBeanstalkClient with the credentials loaded from the application's
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
        public AmazonElasticBeanstalkClient()
            : base(new AmazonElasticBeanstalkConfig()) { }

        /// <summary>
        /// Constructs AmazonElasticBeanstalkClient with the credentials loaded from the application's
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
        public AmazonElasticBeanstalkClient(RegionEndpoint region)
            : base(new AmazonElasticBeanstalkConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonElasticBeanstalkClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonElasticBeanstalkClient Configuration Object</param>
        public AmazonElasticBeanstalkClient(AmazonElasticBeanstalkConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonElasticBeanstalkClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonElasticBeanstalkClient(AWSCredentials credentials)
            : this(credentials, new AmazonElasticBeanstalkConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticBeanstalkClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticBeanstalkClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonElasticBeanstalkConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticBeanstalkClient with AWS Credentials and an
        /// AmazonElasticBeanstalkClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonElasticBeanstalkClient Configuration Object</param>
        public AmazonElasticBeanstalkClient(AWSCredentials credentials, AmazonElasticBeanstalkConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticBeanstalkClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonElasticBeanstalkClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticBeanstalkConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticBeanstalkClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticBeanstalkClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticBeanstalkConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticBeanstalkClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticBeanstalkClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonElasticBeanstalkClient Configuration Object</param>
        public AmazonElasticBeanstalkClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonElasticBeanstalkConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticBeanstalkClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonElasticBeanstalkClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticBeanstalkConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticBeanstalkClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticBeanstalkClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticBeanstalkConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticBeanstalkClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticBeanstalkClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonElasticBeanstalkClient Configuration Object</param>
        public AmazonElasticBeanstalkClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonElasticBeanstalkConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonElasticBeanstalkEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonElasticBeanstalkAuthSchemeHandler());
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


        #region  AbortEnvironmentUpdate


        /// <summary>
        /// Cancels in-progress environment configuration update or application version deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AbortEnvironmentUpdate service method.</param>
        /// 
        /// <returns>The response from the AbortEnvironmentUpdate service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/AbortEnvironmentUpdate">REST API Reference for AbortEnvironmentUpdate Operation</seealso>
        public virtual AbortEnvironmentUpdateResponse AbortEnvironmentUpdate(AbortEnvironmentUpdateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AbortEnvironmentUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AbortEnvironmentUpdateResponseUnmarshaller.Instance;

            return Invoke<AbortEnvironmentUpdateResponse>(request, options);
        }


        /// <summary>
        /// Cancels in-progress environment configuration update or application version deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AbortEnvironmentUpdate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AbortEnvironmentUpdate service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/AbortEnvironmentUpdate">REST API Reference for AbortEnvironmentUpdate Operation</seealso>
        public virtual Task<AbortEnvironmentUpdateResponse> AbortEnvironmentUpdateAsync(AbortEnvironmentUpdateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AbortEnvironmentUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AbortEnvironmentUpdateResponseUnmarshaller.Instance;
            
            return InvokeAsync<AbortEnvironmentUpdateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ApplyEnvironmentManagedAction


        /// <summary>
        /// Applies a scheduled managed action immediately. A managed action can be applied only
        /// if its status is <c>Scheduled</c>. Get the status and action ID of a managed action
        /// with <a>DescribeEnvironmentManagedActions</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApplyEnvironmentManagedAction service method.</param>
        /// 
        /// <returns>The response from the ApplyEnvironmentManagedAction service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ElasticBeanstalkServiceException">
        /// A generic service exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ManagedActionInvalidStateException">
        /// Cannot modify the managed action in its current state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ApplyEnvironmentManagedAction">REST API Reference for ApplyEnvironmentManagedAction Operation</seealso>
        public virtual ApplyEnvironmentManagedActionResponse ApplyEnvironmentManagedAction(ApplyEnvironmentManagedActionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ApplyEnvironmentManagedActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApplyEnvironmentManagedActionResponseUnmarshaller.Instance;

            return Invoke<ApplyEnvironmentManagedActionResponse>(request, options);
        }


        /// <summary>
        /// Applies a scheduled managed action immediately. A managed action can be applied only
        /// if its status is <c>Scheduled</c>. Get the status and action ID of a managed action
        /// with <a>DescribeEnvironmentManagedActions</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApplyEnvironmentManagedAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ApplyEnvironmentManagedAction service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ElasticBeanstalkServiceException">
        /// A generic service exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ManagedActionInvalidStateException">
        /// Cannot modify the managed action in its current state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ApplyEnvironmentManagedAction">REST API Reference for ApplyEnvironmentManagedAction Operation</seealso>
        public virtual Task<ApplyEnvironmentManagedActionResponse> ApplyEnvironmentManagedActionAsync(ApplyEnvironmentManagedActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ApplyEnvironmentManagedActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApplyEnvironmentManagedActionResponseUnmarshaller.Instance;
            
            return InvokeAsync<ApplyEnvironmentManagedActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateEnvironmentOperationsRole


        /// <summary>
        /// Add or change the operations role used by an environment. After this call is made,
        /// Elastic Beanstalk uses the associated operations role for permissions to downstream
        /// services during subsequent calls acting on this environment. For more information,
        /// see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/iam-operationsrole.html">Operations
        /// roles</a> in the <i>AWS Elastic Beanstalk Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateEnvironmentOperationsRole service method.</param>
        /// 
        /// <returns>The response from the AssociateEnvironmentOperationsRole service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/AssociateEnvironmentOperationsRole">REST API Reference for AssociateEnvironmentOperationsRole Operation</seealso>
        public virtual AssociateEnvironmentOperationsRoleResponse AssociateEnvironmentOperationsRole(AssociateEnvironmentOperationsRoleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateEnvironmentOperationsRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateEnvironmentOperationsRoleResponseUnmarshaller.Instance;

            return Invoke<AssociateEnvironmentOperationsRoleResponse>(request, options);
        }


        /// <summary>
        /// Add or change the operations role used by an environment. After this call is made,
        /// Elastic Beanstalk uses the associated operations role for permissions to downstream
        /// services during subsequent calls acting on this environment. For more information,
        /// see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/iam-operationsrole.html">Operations
        /// roles</a> in the <i>AWS Elastic Beanstalk Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateEnvironmentOperationsRole service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateEnvironmentOperationsRole service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/AssociateEnvironmentOperationsRole">REST API Reference for AssociateEnvironmentOperationsRole Operation</seealso>
        public virtual Task<AssociateEnvironmentOperationsRoleResponse> AssociateEnvironmentOperationsRoleAsync(AssociateEnvironmentOperationsRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateEnvironmentOperationsRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateEnvironmentOperationsRoleResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateEnvironmentOperationsRoleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CheckDNSAvailability


        /// <summary>
        /// Checks if the specified CNAME is available.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckDNSAvailability service method.</param>
        /// 
        /// <returns>The response from the CheckDNSAvailability service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CheckDNSAvailability">REST API Reference for CheckDNSAvailability Operation</seealso>
        public virtual CheckDNSAvailabilityResponse CheckDNSAvailability(CheckDNSAvailabilityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CheckDNSAvailabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CheckDNSAvailabilityResponseUnmarshaller.Instance;

            return Invoke<CheckDNSAvailabilityResponse>(request, options);
        }


        /// <summary>
        /// Checks if the specified CNAME is available.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckDNSAvailability service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CheckDNSAvailability service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CheckDNSAvailability">REST API Reference for CheckDNSAvailability Operation</seealso>
        public virtual Task<CheckDNSAvailabilityResponse> CheckDNSAvailabilityAsync(CheckDNSAvailabilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CheckDNSAvailabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CheckDNSAvailabilityResponseUnmarshaller.Instance;
            
            return InvokeAsync<CheckDNSAvailabilityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ComposeEnvironments


        /// <summary>
        /// Create or update a group of environments that each run a separate component of a single
        /// application. Takes a list of version labels that specify application source bundles
        /// for each of the environments to create or update. The name of each environment and
        /// other required information must be included in the source bundles in an environment
        /// manifest named <c>env.yaml</c>. See <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/environment-mgmt-compose.html">Compose
        /// Environments</a> for details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ComposeEnvironments service method.</param>
        /// 
        /// <returns>The response from the ComposeEnvironments service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyEnvironmentsException">
        /// The specified account has reached its limit of environments.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ComposeEnvironments">REST API Reference for ComposeEnvironments Operation</seealso>
        public virtual ComposeEnvironmentsResponse ComposeEnvironments(ComposeEnvironmentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ComposeEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ComposeEnvironmentsResponseUnmarshaller.Instance;

            return Invoke<ComposeEnvironmentsResponse>(request, options);
        }


        /// <summary>
        /// Create or update a group of environments that each run a separate component of a single
        /// application. Takes a list of version labels that specify application source bundles
        /// for each of the environments to create or update. The name of each environment and
        /// other required information must be included in the source bundles in an environment
        /// manifest named <c>env.yaml</c>. See <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/environment-mgmt-compose.html">Compose
        /// Environments</a> for details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ComposeEnvironments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ComposeEnvironments service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyEnvironmentsException">
        /// The specified account has reached its limit of environments.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ComposeEnvironments">REST API Reference for ComposeEnvironments Operation</seealso>
        public virtual Task<ComposeEnvironmentsResponse> ComposeEnvironmentsAsync(ComposeEnvironmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ComposeEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ComposeEnvironmentsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ComposeEnvironmentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateApplication


        /// <summary>
        /// Creates an application that has one configuration template named <c>default</c> and
        /// no application versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyApplicationsException">
        /// The specified account has reached its limit of applications.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationResponse>(request, options);
        }


        /// <summary>
        /// Creates an application that has one configuration template named <c>default</c> and
        /// no application versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyApplicationsException">
        /// The specified account has reached its limit of applications.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateApplicationVersion


        /// <summary>
        /// Creates an application version for the specified application. You can create an application
        /// version from a source bundle in Amazon S3, a commit in AWS CodeCommit, or the output
        /// of an AWS CodeBuild build as follows:
        /// 
        ///  
        /// <para>
        /// Specify a commit in an AWS CodeCommit repository with <c>SourceBuildInformation</c>.
        /// </para>
        ///  
        /// <para>
        /// Specify a build in an AWS CodeBuild with <c>SourceBuildInformation</c> and <c>BuildConfiguration</c>.
        /// </para>
        ///  
        /// <para>
        /// Specify a source bundle in S3 with <c>SourceBundle</c> 
        /// </para>
        ///  
        /// <para>
        /// Omit both <c>SourceBuildInformation</c> and <c>SourceBundle</c> to use the default
        /// sample application.
        /// </para>
        ///  <note> 
        /// <para>
        /// After you create an application version with a specified Amazon S3 bucket and key
        /// location, you can't change that Amazon S3 location. If you change the Amazon S3 location,
        /// you receive an exception when you attempt to launch an environment from the application
        /// version.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplicationVersion service method.</param>
        /// 
        /// <returns>The response from the CreateApplicationVersion service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.CodeBuildNotInServiceRegionException">
        /// AWS CodeBuild is not available in the specified region.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.S3LocationNotInServiceRegionException">
        /// The specified S3 bucket does not belong to the S3 region in which the service is running.
        /// The following regions are supported:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// IAD/us-east-1
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PDX/us-west-2
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DUB/eu-west-1
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyApplicationsException">
        /// The specified account has reached its limit of applications.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyApplicationVersionsException">
        /// The specified account has reached its limit of application versions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreateApplicationVersion">REST API Reference for CreateApplicationVersion Operation</seealso>
        public virtual CreateApplicationVersionResponse CreateApplicationVersion(CreateApplicationVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApplicationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationVersionResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationVersionResponse>(request, options);
        }


        /// <summary>
        /// Creates an application version for the specified application. You can create an application
        /// version from a source bundle in Amazon S3, a commit in AWS CodeCommit, or the output
        /// of an AWS CodeBuild build as follows:
        /// 
        ///  
        /// <para>
        /// Specify a commit in an AWS CodeCommit repository with <c>SourceBuildInformation</c>.
        /// </para>
        ///  
        /// <para>
        /// Specify a build in an AWS CodeBuild with <c>SourceBuildInformation</c> and <c>BuildConfiguration</c>.
        /// </para>
        ///  
        /// <para>
        /// Specify a source bundle in S3 with <c>SourceBundle</c> 
        /// </para>
        ///  
        /// <para>
        /// Omit both <c>SourceBuildInformation</c> and <c>SourceBundle</c> to use the default
        /// sample application.
        /// </para>
        ///  <note> 
        /// <para>
        /// After you create an application version with a specified Amazon S3 bucket and key
        /// location, you can't change that Amazon S3 location. If you change the Amazon S3 location,
        /// you receive an exception when you attempt to launch an environment from the application
        /// version.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplicationVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApplicationVersion service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.CodeBuildNotInServiceRegionException">
        /// AWS CodeBuild is not available in the specified region.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.S3LocationNotInServiceRegionException">
        /// The specified S3 bucket does not belong to the S3 region in which the service is running.
        /// The following regions are supported:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// IAD/us-east-1
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PDX/us-west-2
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DUB/eu-west-1
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyApplicationsException">
        /// The specified account has reached its limit of applications.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyApplicationVersionsException">
        /// The specified account has reached its limit of application versions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreateApplicationVersion">REST API Reference for CreateApplicationVersion Operation</seealso>
        public virtual Task<CreateApplicationVersionResponse> CreateApplicationVersionAsync(CreateApplicationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApplicationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationVersionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateApplicationVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateConfigurationTemplate


        /// <summary>
        /// Creates an AWS Elastic Beanstalk configuration template, associated with a specific
        /// Elastic Beanstalk application. You define application configuration settings in a
        /// configuration template. You can then use the configuration template to deploy different
        /// versions of the application with the same configuration settings.
        /// 
        ///  
        /// <para>
        /// Templates aren't associated with any environment. The <c>EnvironmentName</c> response
        /// element is always <c>null</c>.
        /// </para>
        ///  
        /// <para>
        /// Related Topics
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeConfigurationOptions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeConfigurationSettings</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAvailableSolutionStacks</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateConfigurationTemplate service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyConfigurationTemplatesException">
        /// The specified account has reached its limit of configuration templates.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreateConfigurationTemplate">REST API Reference for CreateConfigurationTemplate Operation</seealso>
        public virtual CreateConfigurationTemplateResponse CreateConfigurationTemplate(CreateConfigurationTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateConfigurationTemplateResponse>(request, options);
        }


        /// <summary>
        /// Creates an AWS Elastic Beanstalk configuration template, associated with a specific
        /// Elastic Beanstalk application. You define application configuration settings in a
        /// configuration template. You can then use the configuration template to deploy different
        /// versions of the application with the same configuration settings.
        /// 
        ///  
        /// <para>
        /// Templates aren't associated with any environment. The <c>EnvironmentName</c> response
        /// element is always <c>null</c>.
        /// </para>
        ///  
        /// <para>
        /// Related Topics
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeConfigurationOptions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeConfigurationSettings</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAvailableSolutionStacks</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConfigurationTemplate service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyConfigurationTemplatesException">
        /// The specified account has reached its limit of configuration templates.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreateConfigurationTemplate">REST API Reference for CreateConfigurationTemplate Operation</seealso>
        public virtual Task<CreateConfigurationTemplateResponse> CreateConfigurationTemplateAsync(CreateConfigurationTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateConfigurationTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEnvironment


        /// <summary>
        /// Launches an AWS Elastic Beanstalk environment for the specified application using
        /// the specified configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment service method.</param>
        /// 
        /// <returns>The response from the CreateEnvironment service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyEnvironmentsException">
        /// The specified account has reached its limit of environments.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        public virtual CreateEnvironmentResponse CreateEnvironment(CreateEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<CreateEnvironmentResponse>(request, options);
        }


        /// <summary>
        /// Launches an AWS Elastic Beanstalk environment for the specified application using
        /// the specified configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEnvironment service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyEnvironmentsException">
        /// The specified account has reached its limit of environments.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        public virtual Task<CreateEnvironmentResponse> CreateEnvironmentAsync(CreateEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePlatformVersion


        /// <summary>
        /// Create a new version of your custom platform.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlatformVersion service method.</param>
        /// 
        /// <returns>The response from the CreatePlatformVersion service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ElasticBeanstalkServiceException">
        /// A generic service exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyPlatformsException">
        /// You have exceeded the maximum number of allowed platforms associated with the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreatePlatformVersion">REST API Reference for CreatePlatformVersion Operation</seealso>
        public virtual CreatePlatformVersionResponse CreatePlatformVersion(CreatePlatformVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePlatformVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlatformVersionResponseUnmarshaller.Instance;

            return Invoke<CreatePlatformVersionResponse>(request, options);
        }


        /// <summary>
        /// Create a new version of your custom platform.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlatformVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePlatformVersion service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ElasticBeanstalkServiceException">
        /// A generic service exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyPlatformsException">
        /// You have exceeded the maximum number of allowed platforms associated with the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreatePlatformVersion">REST API Reference for CreatePlatformVersion Operation</seealso>
        public virtual Task<CreatePlatformVersionResponse> CreatePlatformVersionAsync(CreatePlatformVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePlatformVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlatformVersionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreatePlatformVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateStorageLocation


        /// <summary>
        /// Creates a bucket in Amazon S3 to store application versions, logs, and other files
        /// used by Elastic Beanstalk environments. The Elastic Beanstalk console and EB CLI call
        /// this API the first time you create an environment in a region. If the storage location
        /// already exists, <c>CreateStorageLocation</c> still returns the bucket name but does
        /// not create a new bucket.
        /// </summary>
        /// 
        /// <returns>The response from the CreateStorageLocation service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.S3SubscriptionRequiredException">
        /// The specified account does not have a subscription to Amazon S3.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreateStorageLocation">REST API Reference for CreateStorageLocation Operation</seealso>
        public virtual CreateStorageLocationResponse CreateStorageLocation()
        {
            return CreateStorageLocation(new CreateStorageLocationRequest());
        }


        /// <summary>
        /// Creates a bucket in Amazon S3 to store application versions, logs, and other files
        /// used by Elastic Beanstalk environments. The Elastic Beanstalk console and EB CLI call
        /// this API the first time you create an environment in a region. If the storage location
        /// already exists, <c>CreateStorageLocation</c> still returns the bucket name but does
        /// not create a new bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStorageLocation service method.</param>
        /// 
        /// <returns>The response from the CreateStorageLocation service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.S3SubscriptionRequiredException">
        /// The specified account does not have a subscription to Amazon S3.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreateStorageLocation">REST API Reference for CreateStorageLocation Operation</seealso>
        public virtual CreateStorageLocationResponse CreateStorageLocation(CreateStorageLocationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStorageLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStorageLocationResponseUnmarshaller.Instance;

            return Invoke<CreateStorageLocationResponse>(request, options);
        }


        /// <summary>
        /// Creates a bucket in Amazon S3 to store application versions, logs, and other files
        /// used by Elastic Beanstalk environments. The Elastic Beanstalk console and EB CLI call
        /// this API the first time you create an environment in a region. If the storage location
        /// already exists, <c>CreateStorageLocation</c> still returns the bucket name but does
        /// not create a new bucket.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStorageLocation service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.S3SubscriptionRequiredException">
        /// The specified account does not have a subscription to Amazon S3.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreateStorageLocation">REST API Reference for CreateStorageLocation Operation</seealso>
        public virtual Task<CreateStorageLocationResponse> CreateStorageLocationAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return CreateStorageLocationAsync(new CreateStorageLocationRequest(), cancellationToken);
        }

        /// <summary>
        /// Creates a bucket in Amazon S3 to store application versions, logs, and other files
        /// used by Elastic Beanstalk environments. The Elastic Beanstalk console and EB CLI call
        /// this API the first time you create an environment in a region. If the storage location
        /// already exists, <c>CreateStorageLocation</c> still returns the bucket name but does
        /// not create a new bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStorageLocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStorageLocation service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.S3SubscriptionRequiredException">
        /// The specified account does not have a subscription to Amazon S3.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreateStorageLocation">REST API Reference for CreateStorageLocation Operation</seealso>
        public virtual Task<CreateStorageLocationResponse> CreateStorageLocationAsync(CreateStorageLocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStorageLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStorageLocationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateStorageLocationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteApplication


        /// <summary>
        /// Deletes the specified application along with all associated versions and configurations.
        /// The application versions will not be deleted from your Amazon S3 bucket.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete an application that has a running environment.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.OperationInProgressException">
        /// Unable to perform the specified operation because another operation that effects an
        /// element in this activity is already in progress.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified application along with all associated versions and configurations.
        /// The application versions will not be deleted from your Amazon S3 bucket.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete an application that has a running environment.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.OperationInProgressException">
        /// Unable to perform the specified operation because another operation that effects an
        /// element in this activity is already in progress.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteApplicationVersion


        /// <summary>
        /// Deletes the specified version from the specified application.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete an application version that is associated with a running environment.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteApplicationVersion service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.OperationInProgressException">
        /// Unable to perform the specified operation because another operation that effects an
        /// element in this activity is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.S3LocationNotInServiceRegionException">
        /// The specified S3 bucket does not belong to the S3 region in which the service is running.
        /// The following regions are supported:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// IAD/us-east-1
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PDX/us-west-2
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DUB/eu-west-1
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.SourceBundleDeletionException">
        /// Unable to delete the Amazon S3 source bundle associated with the application version.
        /// The application version was deleted successfully.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DeleteApplicationVersion">REST API Reference for DeleteApplicationVersion Operation</seealso>
        public virtual DeleteApplicationVersionResponse DeleteApplicationVersion(DeleteApplicationVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApplicationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationVersionResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified version from the specified application.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete an application version that is associated with a running environment.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplicationVersion service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.OperationInProgressException">
        /// Unable to perform the specified operation because another operation that effects an
        /// element in this activity is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.S3LocationNotInServiceRegionException">
        /// The specified S3 bucket does not belong to the S3 region in which the service is running.
        /// The following regions are supported:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// IAD/us-east-1
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PDX/us-west-2
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DUB/eu-west-1
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.SourceBundleDeletionException">
        /// Unable to delete the Amazon S3 source bundle associated with the application version.
        /// The application version was deleted successfully.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DeleteApplicationVersion">REST API Reference for DeleteApplicationVersion Operation</seealso>
        public virtual Task<DeleteApplicationVersionResponse> DeleteApplicationVersionAsync(DeleteApplicationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApplicationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationVersionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteApplicationVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteConfigurationTemplate


        /// <summary>
        /// Deletes the specified configuration template.
        /// 
        ///  <note> 
        /// <para>
        /// When you launch an environment using a configuration template, the environment gets
        /// a copy of the template. You can delete or modify the environment's copy of the template
        /// without affecting the running environment.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteConfigurationTemplate service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.OperationInProgressException">
        /// Unable to perform the specified operation because another operation that effects an
        /// element in this activity is already in progress.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DeleteConfigurationTemplate">REST API Reference for DeleteConfigurationTemplate Operation</seealso>
        public virtual DeleteConfigurationTemplateResponse DeleteConfigurationTemplate(DeleteConfigurationTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigurationTemplateResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified configuration template.
        /// 
        ///  <note> 
        /// <para>
        /// When you launch an environment using a configuration template, the environment gets
        /// a copy of the template. You can delete or modify the environment's copy of the template
        /// without affecting the running environment.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConfigurationTemplate service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.OperationInProgressException">
        /// Unable to perform the specified operation because another operation that effects an
        /// element in this activity is already in progress.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DeleteConfigurationTemplate">REST API Reference for DeleteConfigurationTemplate Operation</seealso>
        public virtual Task<DeleteConfigurationTemplateResponse> DeleteConfigurationTemplateAsync(DeleteConfigurationTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteConfigurationTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEnvironmentConfiguration


        /// <summary>
        /// Deletes the draft configuration associated with the running environment.
        /// 
        ///  
        /// <para>
        /// Updating a running environment with any configuration changes creates a draft configuration
        /// set. You can get the draft configuration using <a>DescribeConfigurationSettings</a>
        /// while the update is in progress or if the update fails. The <c>DeploymentStatus</c>
        /// for the draft configuration indicates whether the deployment is in process or has
        /// failed. The draft configuration remains in existence until it is deleted with this
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteEnvironmentConfiguration service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DeleteEnvironmentConfiguration">REST API Reference for DeleteEnvironmentConfiguration Operation</seealso>
        public virtual DeleteEnvironmentConfigurationResponse DeleteEnvironmentConfiguration(DeleteEnvironmentConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteEnvironmentConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Deletes the draft configuration associated with the running environment.
        /// 
        ///  
        /// <para>
        /// Updating a running environment with any configuration changes creates a draft configuration
        /// set. You can get the draft configuration using <a>DescribeConfigurationSettings</a>
        /// while the update is in progress or if the update fails. The <c>DeploymentStatus</c>
        /// for the draft configuration indicates whether the deployment is in process or has
        /// failed. The draft configuration remains in existence until it is deleted with this
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEnvironmentConfiguration service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DeleteEnvironmentConfiguration">REST API Reference for DeleteEnvironmentConfiguration Operation</seealso>
        public virtual Task<DeleteEnvironmentConfigurationResponse> DeleteEnvironmentConfigurationAsync(DeleteEnvironmentConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteEnvironmentConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePlatformVersion


        /// <summary>
        /// Deletes the specified version of a custom platform.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlatformVersion service method.</param>
        /// 
        /// <returns>The response from the DeletePlatformVersion service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ElasticBeanstalkServiceException">
        /// A generic service exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.OperationInProgressException">
        /// Unable to perform the specified operation because another operation that effects an
        /// element in this activity is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.PlatformVersionStillReferencedException">
        /// You cannot delete the platform version because there are still environments running
        /// on it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DeletePlatformVersion">REST API Reference for DeletePlatformVersion Operation</seealso>
        public virtual DeletePlatformVersionResponse DeletePlatformVersion(DeletePlatformVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePlatformVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePlatformVersionResponseUnmarshaller.Instance;

            return Invoke<DeletePlatformVersionResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified version of a custom platform.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlatformVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePlatformVersion service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ElasticBeanstalkServiceException">
        /// A generic service exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.OperationInProgressException">
        /// Unable to perform the specified operation because another operation that effects an
        /// element in this activity is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.PlatformVersionStillReferencedException">
        /// You cannot delete the platform version because there are still environments running
        /// on it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DeletePlatformVersion">REST API Reference for DeletePlatformVersion Operation</seealso>
        public virtual Task<DeletePlatformVersionResponse> DeletePlatformVersionAsync(DeletePlatformVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePlatformVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePlatformVersionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeletePlatformVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAccountAttributes


        /// <summary>
        /// Returns attributes related to AWS Elastic Beanstalk that are associated with the calling
        /// AWS account.
        /// 
        ///  
        /// <para>
        /// The result currently has one set of attributes—resource quotas.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public virtual DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAccountAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountAttributesResponse>(request, options);
        }


        /// <summary>
        /// Returns attributes related to AWS Elastic Beanstalk that are associated with the calling
        /// AWS account.
        /// 
        ///  
        /// <para>
        /// The result currently has one set of attributes—resource quotas.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public virtual Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(DescribeAccountAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAccountAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeAccountAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeApplications


        /// <summary>
        /// Returns the descriptions of existing applications.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeApplications service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeApplications">REST API Reference for DescribeApplications Operation</seealso>
        public virtual DescribeApplicationsResponse DescribeApplications()
        {
            return DescribeApplications(new DescribeApplicationsRequest());
        }


        /// <summary>
        /// Returns the descriptions of existing applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplications service method.</param>
        /// 
        /// <returns>The response from the DescribeApplications service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeApplications">REST API Reference for DescribeApplications Operation</seealso>
        public virtual DescribeApplicationsResponse DescribeApplications(DescribeApplicationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationsResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicationsResponse>(request, options);
        }


        /// <summary>
        /// Returns the descriptions of existing applications.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeApplications service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeApplications">REST API Reference for DescribeApplications Operation</seealso>
        public virtual Task<DescribeApplicationsResponse> DescribeApplicationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeApplicationsAsync(new DescribeApplicationsRequest(), cancellationToken);
        }

        /// <summary>
        /// Returns the descriptions of existing applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeApplications service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeApplications">REST API Reference for DescribeApplications Operation</seealso>
        public virtual Task<DescribeApplicationsResponse> DescribeApplicationsAsync(DescribeApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeApplicationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeApplicationVersions


        /// <summary>
        /// Retrieve a list of application versions.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeApplicationVersions service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeApplicationVersions">REST API Reference for DescribeApplicationVersions Operation</seealso>
        public virtual DescribeApplicationVersionsResponse DescribeApplicationVersions()
        {
            return DescribeApplicationVersions(new DescribeApplicationVersionsRequest());
        }


        /// <summary>
        /// Retrieve a list of application versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeApplicationVersions service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeApplicationVersions">REST API Reference for DescribeApplicationVersions Operation</seealso>
        public virtual DescribeApplicationVersionsResponse DescribeApplicationVersions(DescribeApplicationVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeApplicationVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicationVersionsResponse>(request, options);
        }


        /// <summary>
        /// Retrieve a list of application versions.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeApplicationVersions service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeApplicationVersions">REST API Reference for DescribeApplicationVersions Operation</seealso>
        public virtual Task<DescribeApplicationVersionsResponse> DescribeApplicationVersionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeApplicationVersionsAsync(new DescribeApplicationVersionsRequest(), cancellationToken);
        }

        /// <summary>
        /// Retrieve a list of application versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeApplicationVersions service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeApplicationVersions">REST API Reference for DescribeApplicationVersions Operation</seealso>
        public virtual Task<DescribeApplicationVersionsResponse> DescribeApplicationVersionsAsync(DescribeApplicationVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeApplicationVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationVersionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeApplicationVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeConfigurationOptions


        /// <summary>
        /// Describes the configuration options that are used in a particular configuration template
        /// or environment, or that a specified solution stack defines. The description includes
        /// the values the options, their default values, and an indication of the required action
        /// on a running environment if an option value is changed.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeConfigurationOptions service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeConfigurationOptions">REST API Reference for DescribeConfigurationOptions Operation</seealso>
        public virtual DescribeConfigurationOptionsResponse DescribeConfigurationOptions()
        {
            return DescribeConfigurationOptions(new DescribeConfigurationOptionsRequest());
        }


        /// <summary>
        /// Describes the configuration options that are used in a particular configuration template
        /// or environment, or that a specified solution stack defines. The description includes
        /// the values the options, their default values, and an indication of the required action
        /// on a running environment if an option value is changed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeConfigurationOptions service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeConfigurationOptions">REST API Reference for DescribeConfigurationOptions Operation</seealso>
        public virtual DescribeConfigurationOptionsResponse DescribeConfigurationOptions(DescribeConfigurationOptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigurationOptionsResponse>(request, options);
        }


        /// <summary>
        /// Describes the configuration options that are used in a particular configuration template
        /// or environment, or that a specified solution stack defines. The description includes
        /// the values the options, their default values, and an indication of the required action
        /// on a running environment if an option value is changed.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConfigurationOptions service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeConfigurationOptions">REST API Reference for DescribeConfigurationOptions Operation</seealso>
        public virtual Task<DescribeConfigurationOptionsResponse> DescribeConfigurationOptionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeConfigurationOptionsAsync(new DescribeConfigurationOptionsRequest(), cancellationToken);
        }

        /// <summary>
        /// Describes the configuration options that are used in a particular configuration template
        /// or environment, or that a specified solution stack defines. The description includes
        /// the values the options, their default values, and an indication of the required action
        /// on a running environment if an option value is changed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConfigurationOptions service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeConfigurationOptions">REST API Reference for DescribeConfigurationOptions Operation</seealso>
        public virtual Task<DescribeConfigurationOptionsResponse> DescribeConfigurationOptionsAsync(DescribeConfigurationOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationOptionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeConfigurationOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeConfigurationSettings


        /// <summary>
        /// Returns a description of the settings for the specified configuration set, that is,
        /// either a configuration template or the configuration set associated with a running
        /// environment.
        /// 
        ///  
        /// <para>
        /// When describing the settings for the configuration set associated with a running environment,
        /// it is possible to receive two sets of setting descriptions. One is the deployed configuration
        /// set, and the other is a draft configuration of an environment that is either in the
        /// process of deployment or that failed to deploy.
        /// </para>
        ///  
        /// <para>
        /// Related Topics
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DeleteEnvironmentConfiguration</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationSettings service method.</param>
        /// 
        /// <returns>The response from the DescribeConfigurationSettings service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeConfigurationSettings">REST API Reference for DescribeConfigurationSettings Operation</seealso>
        public virtual DescribeConfigurationSettingsResponse DescribeConfigurationSettings(DescribeConfigurationSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationSettingsResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigurationSettingsResponse>(request, options);
        }


        /// <summary>
        /// Returns a description of the settings for the specified configuration set, that is,
        /// either a configuration template or the configuration set associated with a running
        /// environment.
        /// 
        ///  
        /// <para>
        /// When describing the settings for the configuration set associated with a running environment,
        /// it is possible to receive two sets of setting descriptions. One is the deployed configuration
        /// set, and the other is a draft configuration of an environment that is either in the
        /// process of deployment or that failed to deploy.
        /// </para>
        ///  
        /// <para>
        /// Related Topics
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DeleteEnvironmentConfiguration</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConfigurationSettings service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeConfigurationSettings">REST API Reference for DescribeConfigurationSettings Operation</seealso>
        public virtual Task<DescribeConfigurationSettingsResponse> DescribeConfigurationSettingsAsync(DescribeConfigurationSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationSettingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeConfigurationSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEnvironmentHealth


        /// <summary>
        /// Returns information about the overall health of the specified environment. The <b>DescribeEnvironmentHealth</b>
        /// operation is only available with AWS Elastic Beanstalk Enhanced Health.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentHealth service method.</param>
        /// 
        /// <returns>The response from the DescribeEnvironmentHealth service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ElasticBeanstalkServiceException">
        /// A generic service exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InvalidRequestException">
        /// One or more input parameters is not valid. Please correct the input parameters and
        /// try the operation again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEnvironmentHealth">REST API Reference for DescribeEnvironmentHealth Operation</seealso>
        public virtual DescribeEnvironmentHealthResponse DescribeEnvironmentHealth(DescribeEnvironmentHealthRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEnvironmentHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEnvironmentHealthResponseUnmarshaller.Instance;

            return Invoke<DescribeEnvironmentHealthResponse>(request, options);
        }


        /// <summary>
        /// Returns information about the overall health of the specified environment. The <b>DescribeEnvironmentHealth</b>
        /// operation is only available with AWS Elastic Beanstalk Enhanced Health.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentHealth service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEnvironmentHealth service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ElasticBeanstalkServiceException">
        /// A generic service exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InvalidRequestException">
        /// One or more input parameters is not valid. Please correct the input parameters and
        /// try the operation again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEnvironmentHealth">REST API Reference for DescribeEnvironmentHealth Operation</seealso>
        public virtual Task<DescribeEnvironmentHealthResponse> DescribeEnvironmentHealthAsync(DescribeEnvironmentHealthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEnvironmentHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEnvironmentHealthResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEnvironmentHealthResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEnvironmentManagedActionHistory


        /// <summary>
        /// Lists an environment's completed and failed managed actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentManagedActionHistory service method.</param>
        /// 
        /// <returns>The response from the DescribeEnvironmentManagedActionHistory service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ElasticBeanstalkServiceException">
        /// A generic service exception has occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEnvironmentManagedActionHistory">REST API Reference for DescribeEnvironmentManagedActionHistory Operation</seealso>
        public virtual DescribeEnvironmentManagedActionHistoryResponse DescribeEnvironmentManagedActionHistory(DescribeEnvironmentManagedActionHistoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEnvironmentManagedActionHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEnvironmentManagedActionHistoryResponseUnmarshaller.Instance;

            return Invoke<DescribeEnvironmentManagedActionHistoryResponse>(request, options);
        }


        /// <summary>
        /// Lists an environment's completed and failed managed actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentManagedActionHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEnvironmentManagedActionHistory service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ElasticBeanstalkServiceException">
        /// A generic service exception has occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEnvironmentManagedActionHistory">REST API Reference for DescribeEnvironmentManagedActionHistory Operation</seealso>
        public virtual Task<DescribeEnvironmentManagedActionHistoryResponse> DescribeEnvironmentManagedActionHistoryAsync(DescribeEnvironmentManagedActionHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEnvironmentManagedActionHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEnvironmentManagedActionHistoryResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEnvironmentManagedActionHistoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEnvironmentManagedActions


        /// <summary>
        /// Lists an environment's upcoming and in-progress managed actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentManagedActions service method.</param>
        /// 
        /// <returns>The response from the DescribeEnvironmentManagedActions service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ElasticBeanstalkServiceException">
        /// A generic service exception has occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEnvironmentManagedActions">REST API Reference for DescribeEnvironmentManagedActions Operation</seealso>
        public virtual DescribeEnvironmentManagedActionsResponse DescribeEnvironmentManagedActions(DescribeEnvironmentManagedActionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEnvironmentManagedActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEnvironmentManagedActionsResponseUnmarshaller.Instance;

            return Invoke<DescribeEnvironmentManagedActionsResponse>(request, options);
        }


        /// <summary>
        /// Lists an environment's upcoming and in-progress managed actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentManagedActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEnvironmentManagedActions service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ElasticBeanstalkServiceException">
        /// A generic service exception has occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEnvironmentManagedActions">REST API Reference for DescribeEnvironmentManagedActions Operation</seealso>
        public virtual Task<DescribeEnvironmentManagedActionsResponse> DescribeEnvironmentManagedActionsAsync(DescribeEnvironmentManagedActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEnvironmentManagedActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEnvironmentManagedActionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEnvironmentManagedActionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEnvironmentResources


        /// <summary>
        /// Returns AWS resources for this environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentResources service method.</param>
        /// 
        /// <returns>The response from the DescribeEnvironmentResources service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEnvironmentResources">REST API Reference for DescribeEnvironmentResources Operation</seealso>
        public virtual DescribeEnvironmentResourcesResponse DescribeEnvironmentResources(DescribeEnvironmentResourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEnvironmentResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEnvironmentResourcesResponseUnmarshaller.Instance;

            return Invoke<DescribeEnvironmentResourcesResponse>(request, options);
        }


        /// <summary>
        /// Returns AWS resources for this environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEnvironmentResources service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEnvironmentResources">REST API Reference for DescribeEnvironmentResources Operation</seealso>
        public virtual Task<DescribeEnvironmentResourcesResponse> DescribeEnvironmentResourcesAsync(DescribeEnvironmentResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEnvironmentResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEnvironmentResourcesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEnvironmentResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEnvironments


        /// <summary>
        /// Returns descriptions for existing environments.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEnvironments service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEnvironments">REST API Reference for DescribeEnvironments Operation</seealso>
        public virtual DescribeEnvironmentsResponse DescribeEnvironments()
        {
            return DescribeEnvironments(new DescribeEnvironmentsRequest());
        }


        /// <summary>
        /// Returns descriptions for existing environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironments service method.</param>
        /// 
        /// <returns>The response from the DescribeEnvironments service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEnvironments">REST API Reference for DescribeEnvironments Operation</seealso>
        public virtual DescribeEnvironmentsResponse DescribeEnvironments(DescribeEnvironmentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEnvironmentsResponseUnmarshaller.Instance;

            return Invoke<DescribeEnvironmentsResponse>(request, options);
        }


        /// <summary>
        /// Returns descriptions for existing environments.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEnvironments service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEnvironments">REST API Reference for DescribeEnvironments Operation</seealso>
        public virtual Task<DescribeEnvironmentsResponse> DescribeEnvironmentsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeEnvironmentsAsync(new DescribeEnvironmentsRequest(), cancellationToken);
        }

        /// <summary>
        /// Returns descriptions for existing environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEnvironments service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEnvironments">REST API Reference for DescribeEnvironments Operation</seealso>
        public virtual Task<DescribeEnvironmentsResponse> DescribeEnvironmentsAsync(DescribeEnvironmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEnvironmentsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEnvironmentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEvents


        /// <summary>
        /// Returns list of event descriptions matching criteria up to the last 6 weeks.
        /// 
        ///  <note> 
        /// <para>
        /// This action returns the most recent 1,000 events from the specified <c>NextToken</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual DescribeEventsResponse DescribeEvents()
        {
            return DescribeEvents(new DescribeEventsRequest());
        }


        /// <summary>
        /// Returns list of event descriptions matching criteria up to the last 6 weeks.
        /// 
        ///  <note> 
        /// <para>
        /// This action returns the most recent 1,000 events from the specified <c>NextToken</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventsResponse>(request, options);
        }


        /// <summary>
        /// Returns list of event descriptions matching criteria up to the last 6 weeks.
        /// 
        ///  <note> 
        /// <para>
        /// This action returns the most recent 1,000 events from the specified <c>NextToken</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual Task<DescribeEventsResponse> DescribeEventsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeEventsAsync(new DescribeEventsRequest(), cancellationToken);
        }

        /// <summary>
        /// Returns list of event descriptions matching criteria up to the last 6 weeks.
        /// 
        ///  <note> 
        /// <para>
        /// This action returns the most recent 1,000 events from the specified <c>NextToken</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstancesHealth


        /// <summary>
        /// Retrieves detailed information about the health of instances in your AWS Elastic Beanstalk.
        /// This operation requires <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/health-enhanced.html">enhanced
        /// health reporting</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstancesHealth service method.</param>
        /// 
        /// <returns>The response from the DescribeInstancesHealth service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ElasticBeanstalkServiceException">
        /// A generic service exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InvalidRequestException">
        /// One or more input parameters is not valid. Please correct the input parameters and
        /// try the operation again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeInstancesHealth">REST API Reference for DescribeInstancesHealth Operation</seealso>
        public virtual DescribeInstancesHealthResponse DescribeInstancesHealth(DescribeInstancesHealthRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeInstancesHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstancesHealthResponseUnmarshaller.Instance;

            return Invoke<DescribeInstancesHealthResponse>(request, options);
        }


        /// <summary>
        /// Retrieves detailed information about the health of instances in your AWS Elastic Beanstalk.
        /// This operation requires <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/health-enhanced.html">enhanced
        /// health reporting</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstancesHealth service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstancesHealth service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ElasticBeanstalkServiceException">
        /// A generic service exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InvalidRequestException">
        /// One or more input parameters is not valid. Please correct the input parameters and
        /// try the operation again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeInstancesHealth">REST API Reference for DescribeInstancesHealth Operation</seealso>
        public virtual Task<DescribeInstancesHealthResponse> DescribeInstancesHealthAsync(DescribeInstancesHealthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeInstancesHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstancesHealthResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeInstancesHealthResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePlatformVersion


        /// <summary>
        /// Describes a platform version. Provides full details. Compare to <a>ListPlatformVersions</a>,
        /// which provides summary information about a list of platform versions.
        /// 
        ///  
        /// <para>
        /// For definitions of platform version and other platform-related terms, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/platforms-glossary.html">AWS
        /// Elastic Beanstalk Platforms Glossary</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePlatformVersion service method.</param>
        /// 
        /// <returns>The response from the DescribePlatformVersion service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ElasticBeanstalkServiceException">
        /// A generic service exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribePlatformVersion">REST API Reference for DescribePlatformVersion Operation</seealso>
        public virtual DescribePlatformVersionResponse DescribePlatformVersion(DescribePlatformVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePlatformVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePlatformVersionResponseUnmarshaller.Instance;

            return Invoke<DescribePlatformVersionResponse>(request, options);
        }


        /// <summary>
        /// Describes a platform version. Provides full details. Compare to <a>ListPlatformVersions</a>,
        /// which provides summary information about a list of platform versions.
        /// 
        ///  
        /// <para>
        /// For definitions of platform version and other platform-related terms, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/platforms-glossary.html">AWS
        /// Elastic Beanstalk Platforms Glossary</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePlatformVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePlatformVersion service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ElasticBeanstalkServiceException">
        /// A generic service exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribePlatformVersion">REST API Reference for DescribePlatformVersion Operation</seealso>
        public virtual Task<DescribePlatformVersionResponse> DescribePlatformVersionAsync(DescribePlatformVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePlatformVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePlatformVersionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribePlatformVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateEnvironmentOperationsRole


        /// <summary>
        /// Disassociate the operations role from an environment. After this call is made, Elastic
        /// Beanstalk uses the caller's permissions for permissions to downstream services during
        /// subsequent calls acting on this environment. For more information, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/iam-operationsrole.html">Operations
        /// roles</a> in the <i>AWS Elastic Beanstalk Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateEnvironmentOperationsRole service method.</param>
        /// 
        /// <returns>The response from the DisassociateEnvironmentOperationsRole service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DisassociateEnvironmentOperationsRole">REST API Reference for DisassociateEnvironmentOperationsRole Operation</seealso>
        public virtual DisassociateEnvironmentOperationsRoleResponse DisassociateEnvironmentOperationsRole(DisassociateEnvironmentOperationsRoleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateEnvironmentOperationsRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateEnvironmentOperationsRoleResponseUnmarshaller.Instance;

            return Invoke<DisassociateEnvironmentOperationsRoleResponse>(request, options);
        }


        /// <summary>
        /// Disassociate the operations role from an environment. After this call is made, Elastic
        /// Beanstalk uses the caller's permissions for permissions to downstream services during
        /// subsequent calls acting on this environment. For more information, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/iam-operationsrole.html">Operations
        /// roles</a> in the <i>AWS Elastic Beanstalk Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateEnvironmentOperationsRole service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateEnvironmentOperationsRole service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DisassociateEnvironmentOperationsRole">REST API Reference for DisassociateEnvironmentOperationsRole Operation</seealso>
        public virtual Task<DisassociateEnvironmentOperationsRoleResponse> DisassociateEnvironmentOperationsRoleAsync(DisassociateEnvironmentOperationsRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateEnvironmentOperationsRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateEnvironmentOperationsRoleResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateEnvironmentOperationsRoleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAvailableSolutionStacks


        /// <summary>
        /// Returns a list of the available solution stack names, with the public version first
        /// and then in reverse chronological order.
        /// </summary>
        /// 
        /// <returns>The response from the ListAvailableSolutionStacks service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ListAvailableSolutionStacks">REST API Reference for ListAvailableSolutionStacks Operation</seealso>
        public virtual ListAvailableSolutionStacksResponse ListAvailableSolutionStacks()
        {
            return ListAvailableSolutionStacks(new ListAvailableSolutionStacksRequest());
        }


        /// <summary>
        /// Returns a list of the available solution stack names, with the public version first
        /// and then in reverse chronological order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableSolutionStacks service method.</param>
        /// 
        /// <returns>The response from the ListAvailableSolutionStacks service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ListAvailableSolutionStacks">REST API Reference for ListAvailableSolutionStacks Operation</seealso>
        public virtual ListAvailableSolutionStacksResponse ListAvailableSolutionStacks(ListAvailableSolutionStacksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAvailableSolutionStacksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAvailableSolutionStacksResponseUnmarshaller.Instance;

            return Invoke<ListAvailableSolutionStacksResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of the available solution stack names, with the public version first
        /// and then in reverse chronological order.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAvailableSolutionStacks service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ListAvailableSolutionStacks">REST API Reference for ListAvailableSolutionStacks Operation</seealso>
        public virtual Task<ListAvailableSolutionStacksResponse> ListAvailableSolutionStacksAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListAvailableSolutionStacksAsync(new ListAvailableSolutionStacksRequest(), cancellationToken);
        }

        /// <summary>
        /// Returns a list of the available solution stack names, with the public version first
        /// and then in reverse chronological order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableSolutionStacks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAvailableSolutionStacks service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ListAvailableSolutionStacks">REST API Reference for ListAvailableSolutionStacks Operation</seealso>
        public virtual Task<ListAvailableSolutionStacksResponse> ListAvailableSolutionStacksAsync(ListAvailableSolutionStacksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAvailableSolutionStacksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAvailableSolutionStacksResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAvailableSolutionStacksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPlatformBranches


        /// <summary>
        /// Lists the platform branches available for your account in an AWS Region. Provides
        /// summary information about each platform branch.
        /// 
        ///  
        /// <para>
        /// For definitions of platform branch and other platform-related terms, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/platforms-glossary.html">AWS
        /// Elastic Beanstalk Platforms Glossary</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlatformBranches service method.</param>
        /// 
        /// <returns>The response from the ListPlatformBranches service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ListPlatformBranches">REST API Reference for ListPlatformBranches Operation</seealso>
        public virtual ListPlatformBranchesResponse ListPlatformBranches(ListPlatformBranchesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPlatformBranchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlatformBranchesResponseUnmarshaller.Instance;

            return Invoke<ListPlatformBranchesResponse>(request, options);
        }


        /// <summary>
        /// Lists the platform branches available for your account in an AWS Region. Provides
        /// summary information about each platform branch.
        /// 
        ///  
        /// <para>
        /// For definitions of platform branch and other platform-related terms, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/platforms-glossary.html">AWS
        /// Elastic Beanstalk Platforms Glossary</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlatformBranches service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPlatformBranches service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ListPlatformBranches">REST API Reference for ListPlatformBranches Operation</seealso>
        public virtual Task<ListPlatformBranchesResponse> ListPlatformBranchesAsync(ListPlatformBranchesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPlatformBranchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlatformBranchesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPlatformBranchesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPlatformVersions


        /// <summary>
        /// Lists the platform versions available for your account in an AWS Region. Provides
        /// summary information about each platform version. Compare to <a>DescribePlatformVersion</a>,
        /// which provides full details about a single platform version.
        /// 
        ///  
        /// <para>
        /// For definitions of platform version and other platform-related terms, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/platforms-glossary.html">AWS
        /// Elastic Beanstalk Platforms Glossary</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlatformVersions service method.</param>
        /// 
        /// <returns>The response from the ListPlatformVersions service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ElasticBeanstalkServiceException">
        /// A generic service exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ListPlatformVersions">REST API Reference for ListPlatformVersions Operation</seealso>
        public virtual ListPlatformVersionsResponse ListPlatformVersions(ListPlatformVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPlatformVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlatformVersionsResponseUnmarshaller.Instance;

            return Invoke<ListPlatformVersionsResponse>(request, options);
        }


        /// <summary>
        /// Lists the platform versions available for your account in an AWS Region. Provides
        /// summary information about each platform version. Compare to <a>DescribePlatformVersion</a>,
        /// which provides full details about a single platform version.
        /// 
        ///  
        /// <para>
        /// For definitions of platform version and other platform-related terms, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/platforms-glossary.html">AWS
        /// Elastic Beanstalk Platforms Glossary</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlatformVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPlatformVersions service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ElasticBeanstalkServiceException">
        /// A generic service exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ListPlatformVersions">REST API Reference for ListPlatformVersions Operation</seealso>
        public virtual Task<ListPlatformVersionsResponse> ListPlatformVersionsAsync(ListPlatformVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPlatformVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlatformVersionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPlatformVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Return the tags applied to an AWS Elastic Beanstalk resource. The response contains
        /// a list of tag key-value pairs.
        /// 
        ///  
        /// <para>
        /// Elastic Beanstalk supports tagging of all of its resources. For details about resource
        /// tagging, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/applications-tagging-resources.html">Tagging
        /// Application Resources</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN).
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ResourceTypeNotSupportedException">
        /// The type of the specified Amazon Resource Name (ARN) isn't supported for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Return the tags applied to an AWS Elastic Beanstalk resource. The response contains
        /// a list of tag key-value pairs.
        /// 
        ///  
        /// <para>
        /// Elastic Beanstalk supports tagging of all of its resources. For details about resource
        /// tagging, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/applications-tagging-resources.html">Tagging
        /// Application Resources</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN).
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ResourceTypeNotSupportedException">
        /// The type of the specified Amazon Resource Name (ARN) isn't supported for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RebuildEnvironment


        /// <summary>
        /// Deletes and recreates all of the AWS resources (for example: the Auto Scaling group,
        /// load balancer, etc.) for a specified environment and forces a restart.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebuildEnvironment service method.</param>
        /// 
        /// <returns>The response from the RebuildEnvironment service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/RebuildEnvironment">REST API Reference for RebuildEnvironment Operation</seealso>
        public virtual RebuildEnvironmentResponse RebuildEnvironment(RebuildEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RebuildEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebuildEnvironmentResponseUnmarshaller.Instance;

            return Invoke<RebuildEnvironmentResponse>(request, options);
        }


        /// <summary>
        /// Deletes and recreates all of the AWS resources (for example: the Auto Scaling group,
        /// load balancer, etc.) for a specified environment and forces a restart.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebuildEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RebuildEnvironment service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/RebuildEnvironment">REST API Reference for RebuildEnvironment Operation</seealso>
        public virtual Task<RebuildEnvironmentResponse> RebuildEnvironmentAsync(RebuildEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RebuildEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebuildEnvironmentResponseUnmarshaller.Instance;
            
            return InvokeAsync<RebuildEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RequestEnvironmentInfo


        /// <summary>
        /// Initiates a request to compile the specified type of information of the deployed environment.
        /// 
        ///  
        /// <para>
        ///  Setting the <c>InfoType</c> to <c>tail</c> compiles the last lines from the application
        /// server log files of every Amazon EC2 instance in your environment. 
        /// </para>
        ///  
        /// <para>
        ///  Setting the <c>InfoType</c> to <c>bundle</c> compresses the application server log
        /// files for every Amazon EC2 instance into a <c>.zip</c> file. Legacy and .NET containers
        /// do not support bundle logs. 
        /// </para>
        ///  
        /// <para>
        ///  Use <a>RetrieveEnvironmentInfo</a> to obtain the set of logs. 
        /// </para>
        ///  
        /// <para>
        /// Related Topics
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>RetrieveEnvironmentInfo</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestEnvironmentInfo service method.</param>
        /// 
        /// <returns>The response from the RequestEnvironmentInfo service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/RequestEnvironmentInfo">REST API Reference for RequestEnvironmentInfo Operation</seealso>
        public virtual RequestEnvironmentInfoResponse RequestEnvironmentInfo(RequestEnvironmentInfoRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RequestEnvironmentInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RequestEnvironmentInfoResponseUnmarshaller.Instance;

            return Invoke<RequestEnvironmentInfoResponse>(request, options);
        }


        /// <summary>
        /// Initiates a request to compile the specified type of information of the deployed environment.
        /// 
        ///  
        /// <para>
        ///  Setting the <c>InfoType</c> to <c>tail</c> compiles the last lines from the application
        /// server log files of every Amazon EC2 instance in your environment. 
        /// </para>
        ///  
        /// <para>
        ///  Setting the <c>InfoType</c> to <c>bundle</c> compresses the application server log
        /// files for every Amazon EC2 instance into a <c>.zip</c> file. Legacy and .NET containers
        /// do not support bundle logs. 
        /// </para>
        ///  
        /// <para>
        ///  Use <a>RetrieveEnvironmentInfo</a> to obtain the set of logs. 
        /// </para>
        ///  
        /// <para>
        /// Related Topics
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>RetrieveEnvironmentInfo</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestEnvironmentInfo service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RequestEnvironmentInfo service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/RequestEnvironmentInfo">REST API Reference for RequestEnvironmentInfo Operation</seealso>
        public virtual Task<RequestEnvironmentInfoResponse> RequestEnvironmentInfoAsync(RequestEnvironmentInfoRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RequestEnvironmentInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RequestEnvironmentInfoResponseUnmarshaller.Instance;
            
            return InvokeAsync<RequestEnvironmentInfoResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RestartAppServer


        /// <summary>
        /// Causes the environment to restart the application container server running on each
        /// Amazon EC2 instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestartAppServer service method.</param>
        /// 
        /// <returns>The response from the RestartAppServer service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/RestartAppServer">REST API Reference for RestartAppServer Operation</seealso>
        public virtual RestartAppServerResponse RestartAppServer(RestartAppServerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestartAppServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestartAppServerResponseUnmarshaller.Instance;

            return Invoke<RestartAppServerResponse>(request, options);
        }


        /// <summary>
        /// Causes the environment to restart the application container server running on each
        /// Amazon EC2 instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestartAppServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestartAppServer service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/RestartAppServer">REST API Reference for RestartAppServer Operation</seealso>
        public virtual Task<RestartAppServerResponse> RestartAppServerAsync(RestartAppServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestartAppServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestartAppServerResponseUnmarshaller.Instance;
            
            return InvokeAsync<RestartAppServerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RetrieveEnvironmentInfo


        /// <summary>
        /// Retrieves the compiled information from a <a>RequestEnvironmentInfo</a> request.
        /// 
        ///  
        /// <para>
        /// Related Topics
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>RequestEnvironmentInfo</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetrieveEnvironmentInfo service method.</param>
        /// 
        /// <returns>The response from the RetrieveEnvironmentInfo service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/RetrieveEnvironmentInfo">REST API Reference for RetrieveEnvironmentInfo Operation</seealso>
        public virtual RetrieveEnvironmentInfoResponse RetrieveEnvironmentInfo(RetrieveEnvironmentInfoRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RetrieveEnvironmentInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetrieveEnvironmentInfoResponseUnmarshaller.Instance;

            return Invoke<RetrieveEnvironmentInfoResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the compiled information from a <a>RequestEnvironmentInfo</a> request.
        /// 
        ///  
        /// <para>
        /// Related Topics
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>RequestEnvironmentInfo</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetrieveEnvironmentInfo service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RetrieveEnvironmentInfo service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/RetrieveEnvironmentInfo">REST API Reference for RetrieveEnvironmentInfo Operation</seealso>
        public virtual Task<RetrieveEnvironmentInfoResponse> RetrieveEnvironmentInfoAsync(RetrieveEnvironmentInfoRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RetrieveEnvironmentInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetrieveEnvironmentInfoResponseUnmarshaller.Instance;
            
            return InvokeAsync<RetrieveEnvironmentInfoResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SwapEnvironmentCNAMEs


        /// <summary>
        /// Swaps the CNAMEs of two environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SwapEnvironmentCNAMEs service method.</param>
        /// 
        /// <returns>The response from the SwapEnvironmentCNAMEs service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/SwapEnvironmentCNAMEs">REST API Reference for SwapEnvironmentCNAMEs Operation</seealso>
        public virtual SwapEnvironmentCNAMEsResponse SwapEnvironmentCNAMEs(SwapEnvironmentCNAMEsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SwapEnvironmentCNAMEsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SwapEnvironmentCNAMEsResponseUnmarshaller.Instance;

            return Invoke<SwapEnvironmentCNAMEsResponse>(request, options);
        }


        /// <summary>
        /// Swaps the CNAMEs of two environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SwapEnvironmentCNAMEs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SwapEnvironmentCNAMEs service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/SwapEnvironmentCNAMEs">REST API Reference for SwapEnvironmentCNAMEs Operation</seealso>
        public virtual Task<SwapEnvironmentCNAMEsResponse> SwapEnvironmentCNAMEsAsync(SwapEnvironmentCNAMEsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SwapEnvironmentCNAMEsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SwapEnvironmentCNAMEsResponseUnmarshaller.Instance;
            
            return InvokeAsync<SwapEnvironmentCNAMEsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TerminateEnvironment


        /// <summary>
        /// Terminates the specified environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateEnvironment service method.</param>
        /// 
        /// <returns>The response from the TerminateEnvironment service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/TerminateEnvironment">REST API Reference for TerminateEnvironment Operation</seealso>
        public virtual TerminateEnvironmentResponse TerminateEnvironment(TerminateEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TerminateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<TerminateEnvironmentResponse>(request, options);
        }


        /// <summary>
        /// Terminates the specified environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TerminateEnvironment service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/TerminateEnvironment">REST API Reference for TerminateEnvironment Operation</seealso>
        public virtual Task<TerminateEnvironmentResponse> TerminateEnvironmentAsync(TerminateEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TerminateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateEnvironmentResponseUnmarshaller.Instance;
            
            return InvokeAsync<TerminateEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateApplication


        /// <summary>
        /// Updates the specified application to have the specified properties.
        /// 
        ///  <note> 
        /// <para>
        /// If a property (for example, <c>description</c>) is not provided, the value remains
        /// unchanged. To clear these properties, specify an empty string.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationResponse>(request, options);
        }


        /// <summary>
        /// Updates the specified application to have the specified properties.
        /// 
        ///  <note> 
        /// <para>
        /// If a property (for example, <c>description</c>) is not provided, the value remains
        /// unchanged. To clear these properties, specify an empty string.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateApplicationResourceLifecycle


        /// <summary>
        /// Modifies lifecycle settings for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationResourceLifecycle service method.</param>
        /// 
        /// <returns>The response from the UpdateApplicationResourceLifecycle service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/UpdateApplicationResourceLifecycle">REST API Reference for UpdateApplicationResourceLifecycle Operation</seealso>
        public virtual UpdateApplicationResourceLifecycleResponse UpdateApplicationResourceLifecycle(UpdateApplicationResourceLifecycleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApplicationResourceLifecycleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResourceLifecycleResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationResourceLifecycleResponse>(request, options);
        }


        /// <summary>
        /// Modifies lifecycle settings for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationResourceLifecycle service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApplicationResourceLifecycle service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/UpdateApplicationResourceLifecycle">REST API Reference for UpdateApplicationResourceLifecycle Operation</seealso>
        public virtual Task<UpdateApplicationResourceLifecycleResponse> UpdateApplicationResourceLifecycleAsync(UpdateApplicationResourceLifecycleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApplicationResourceLifecycleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResourceLifecycleResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateApplicationResourceLifecycleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateApplicationVersion


        /// <summary>
        /// Updates the specified application version to have the specified properties.
        /// 
        ///  <note> 
        /// <para>
        /// If a property (for example, <c>description</c>) is not provided, the value remains
        /// unchanged. To clear properties, specify an empty string.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateApplicationVersion service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/UpdateApplicationVersion">REST API Reference for UpdateApplicationVersion Operation</seealso>
        public virtual UpdateApplicationVersionResponse UpdateApplicationVersion(UpdateApplicationVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApplicationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationVersionResponse>(request, options);
        }


        /// <summary>
        /// Updates the specified application version to have the specified properties.
        /// 
        ///  <note> 
        /// <para>
        /// If a property (for example, <c>description</c>) is not provided, the value remains
        /// unchanged. To clear properties, specify an empty string.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApplicationVersion service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/UpdateApplicationVersion">REST API Reference for UpdateApplicationVersion Operation</seealso>
        public virtual Task<UpdateApplicationVersionResponse> UpdateApplicationVersionAsync(UpdateApplicationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApplicationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationVersionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateApplicationVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateConfigurationTemplate


        /// <summary>
        /// Updates the specified configuration template to have the specified properties or configuration
        /// option values.
        /// 
        ///  <note> 
        /// <para>
        /// If a property (for example, <c>ApplicationName</c>) is not provided, its value remains
        /// unchanged. To clear such properties, specify an empty string.
        /// </para>
        ///  </note> 
        /// <para>
        /// Related Topics
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeConfigurationOptions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateConfigurationTemplate service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/UpdateConfigurationTemplate">REST API Reference for UpdateConfigurationTemplate Operation</seealso>
        public virtual UpdateConfigurationTemplateResponse UpdateConfigurationTemplate(UpdateConfigurationTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateConfigurationTemplateResponse>(request, options);
        }


        /// <summary>
        /// Updates the specified configuration template to have the specified properties or configuration
        /// option values.
        /// 
        ///  <note> 
        /// <para>
        /// If a property (for example, <c>ApplicationName</c>) is not provided, its value remains
        /// unchanged. To clear such properties, specify an empty string.
        /// </para>
        ///  </note> 
        /// <para>
        /// Related Topics
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeConfigurationOptions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConfigurationTemplate service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/UpdateConfigurationTemplate">REST API Reference for UpdateConfigurationTemplate Operation</seealso>
        public virtual Task<UpdateConfigurationTemplateResponse> UpdateConfigurationTemplateAsync(UpdateConfigurationTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateConfigurationTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEnvironment


        /// <summary>
        /// Updates the environment description, deploys a new application version, updates the
        /// configuration settings to an entirely new configuration template, or updates select
        /// configuration option values in the running environment.
        /// 
        ///  
        /// <para>
        ///  Attempting to update both the release and configuration is not allowed and AWS Elastic
        /// Beanstalk returns an <c>InvalidParameterCombination</c> error. 
        /// </para>
        ///  
        /// <para>
        ///  When updating the configuration settings to a new template or individual settings,
        /// a draft configuration is created and <a>DescribeConfigurationSettings</a> for this
        /// environment returns two setting descriptions with different <c>DeploymentStatus</c>
        /// values. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment service method.</param>
        /// 
        /// <returns>The response from the UpdateEnvironment service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        public virtual UpdateEnvironmentResponse UpdateEnvironment(UpdateEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<UpdateEnvironmentResponse>(request, options);
        }


        /// <summary>
        /// Updates the environment description, deploys a new application version, updates the
        /// configuration settings to an entirely new configuration template, or updates select
        /// configuration option values in the running environment.
        /// 
        ///  
        /// <para>
        ///  Attempting to update both the release and configuration is not allowed and AWS Elastic
        /// Beanstalk returns an <c>InvalidParameterCombination</c> error. 
        /// </para>
        ///  
        /// <para>
        ///  When updating the configuration settings to a new template or individual settings,
        /// a draft configuration is created and <a>DescribeConfigurationSettings</a> for this
        /// environment returns two setting descriptions with different <c>DeploymentStatus</c>
        /// values. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEnvironment service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        public virtual Task<UpdateEnvironmentResponse> UpdateEnvironmentAsync(UpdateEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTagsForResource


        /// <summary>
        /// Update the list of tags applied to an AWS Elastic Beanstalk resource. Two lists can
        /// be passed: <c>TagsToAdd</c> for tags to add or update, and <c>TagsToRemove</c>.
        /// 
        ///  
        /// <para>
        /// Elastic Beanstalk supports tagging of all of its resources. For details about resource
        /// tagging, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/applications-tagging-resources.html">Tagging
        /// Application Resources</a>.
        /// </para>
        ///  
        /// <para>
        /// If you create a custom IAM user policy to control permission to this operation, specify
        /// one of the following two virtual actions (or both) instead of the API operation name:
        /// </para>
        ///  <dl> <dt>elasticbeanstalk:AddTags</dt> <dd> 
        /// <para>
        /// Controls permission to call <c>UpdateTagsForResource</c> and pass a list of tags to
        /// add in the <c>TagsToAdd</c> parameter.
        /// </para>
        ///  </dd> <dt>elasticbeanstalk:RemoveTags</dt> <dd> 
        /// <para>
        /// Controls permission to call <c>UpdateTagsForResource</c> and pass a list of tag keys
        /// to remove in the <c>TagsToRemove</c> parameter.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// For details about creating a custom user policy, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/AWSHowTo.iam.managed-policies.html#AWSHowTo.iam.policies">Creating
        /// a Custom User Policy</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTagsForResource service method.</param>
        /// 
        /// <returns>The response from the UpdateTagsForResource service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.OperationInProgressException">
        /// Unable to perform the specified operation because another operation that effects an
        /// element in this activity is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN).
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ResourceTypeNotSupportedException">
        /// The type of the specified Amazon Resource Name (ARN) isn't supported for this operation.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyTagsException">
        /// The number of tags in the resource would exceed the number of tags that each resource
        /// can have.
        /// 
        ///  
        /// <para>
        /// To calculate this, the operation considers both the number of tags the resource already
        /// has and the tags this operation would add if it succeeded.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/UpdateTagsForResource">REST API Reference for UpdateTagsForResource Operation</seealso>
        public virtual UpdateTagsForResourceResponse UpdateTagsForResource(UpdateTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<UpdateTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Update the list of tags applied to an AWS Elastic Beanstalk resource. Two lists can
        /// be passed: <c>TagsToAdd</c> for tags to add or update, and <c>TagsToRemove</c>.
        /// 
        ///  
        /// <para>
        /// Elastic Beanstalk supports tagging of all of its resources. For details about resource
        /// tagging, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/applications-tagging-resources.html">Tagging
        /// Application Resources</a>.
        /// </para>
        ///  
        /// <para>
        /// If you create a custom IAM user policy to control permission to this operation, specify
        /// one of the following two virtual actions (or both) instead of the API operation name:
        /// </para>
        ///  <dl> <dt>elasticbeanstalk:AddTags</dt> <dd> 
        /// <para>
        /// Controls permission to call <c>UpdateTagsForResource</c> and pass a list of tags to
        /// add in the <c>TagsToAdd</c> parameter.
        /// </para>
        ///  </dd> <dt>elasticbeanstalk:RemoveTags</dt> <dd> 
        /// <para>
        /// Controls permission to call <c>UpdateTagsForResource</c> and pass a list of tag keys
        /// to remove in the <c>TagsToRemove</c> parameter.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// For details about creating a custom user policy, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/AWSHowTo.iam.managed-policies.html#AWSHowTo.iam.policies">Creating
        /// a Custom User Policy</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTagsForResource service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.OperationInProgressException">
        /// Unable to perform the specified operation because another operation that effects an
        /// element in this activity is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ResourceNotFoundException">
        /// A resource doesn't exist for the specified Amazon Resource Name (ARN).
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.ResourceTypeNotSupportedException">
        /// The type of the specified Amazon Resource Name (ARN) isn't supported for this operation.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyTagsException">
        /// The number of tags in the resource would exceed the number of tags that each resource
        /// can have.
        /// 
        ///  
        /// <para>
        /// To calculate this, the operation considers both the number of tags the resource already
        /// has and the tags this operation would add if it succeeded.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/UpdateTagsForResource">REST API Reference for UpdateTagsForResource Operation</seealso>
        public virtual Task<UpdateTagsForResourceResponse> UpdateTagsForResourceAsync(UpdateTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ValidateConfigurationSettings


        /// <summary>
        /// Takes a set of configuration settings and either a configuration template or environment,
        /// and determines whether those values are valid.
        /// 
        ///  
        /// <para>
        /// This action returns a list of messages indicating any errors or warnings associated
        /// with the selection of option values.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateConfigurationSettings service method.</param>
        /// 
        /// <returns>The response from the ValidateConfigurationSettings service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ValidateConfigurationSettings">REST API Reference for ValidateConfigurationSettings Operation</seealso>
        public virtual ValidateConfigurationSettingsResponse ValidateConfigurationSettings(ValidateConfigurationSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ValidateConfigurationSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateConfigurationSettingsResponseUnmarshaller.Instance;

            return Invoke<ValidateConfigurationSettingsResponse>(request, options);
        }


        /// <summary>
        /// Takes a set of configuration settings and either a configuration template or environment,
        /// and determines whether those values are valid.
        /// 
        ///  
        /// <para>
        /// This action returns a list of messages indicating any errors or warnings associated
        /// with the selection of option values.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateConfigurationSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ValidateConfigurationSettings service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ValidateConfigurationSettings">REST API Reference for ValidateConfigurationSettings Operation</seealso>
        public virtual Task<ValidateConfigurationSettingsResponse> ValidateConfigurationSettingsAsync(ValidateConfigurationSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ValidateConfigurationSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateConfigurationSettingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ValidateConfigurationSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}