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
 * Do not modify this file. This file is generated from the cur-2017-01-06.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.CostAndUsageReport.Model;
using Amazon.CostAndUsageReport.Model.Internal.MarshallTransformations;
using Amazon.CostAndUsageReport.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CostAndUsageReport
{
    /// <summary>
    /// Implementation for accessing CostAndUsageReport
    ///
    /// The AWS Cost and Usage Report API enables you to programmatically create, query, and
    /// delete AWS Cost and Usage report definitions.
    /// 
    ///  
    /// <para>
    /// AWS Cost and Usage reports track the monthly AWS costs and usage associated with your
    /// AWS account. The report contains line items for each unique combination of AWS product,
    /// usage type, and operation that your AWS account uses. You can configure the AWS Cost
    /// and Usage report to show only the data that you want, using the AWS Cost and Usage
    /// API.
    /// </para>
    ///  
    /// <para>
    /// Service Endpoint
    /// </para>
    ///  
    /// <para>
    /// The AWS Cost and Usage Report API provides the following endpoint:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// cur.us-east-1.amazonaws.com
    /// </para>
    ///  </li> </ul>
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial class AmazonCostAndUsageReportClient : AmazonServiceClient, IAmazonCostAndUsageReport
    {
        private static IServiceMetadata serviceMetadata = new AmazonCostAndUsageReportMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonCostAndUsageReportClient with the credentials loaded from the application's
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
        public AmazonCostAndUsageReportClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCostAndUsageReportConfig()) { }

        /// <summary>
        /// Constructs AmazonCostAndUsageReportClient with the credentials loaded from the application's
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
        public AmazonCostAndUsageReportClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCostAndUsageReportConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCostAndUsageReportClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCostAndUsageReportClient Configuration Object</param>
        public AmazonCostAndUsageReportClient(AmazonCostAndUsageReportConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonCostAndUsageReportClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCostAndUsageReportClient(AWSCredentials credentials)
            : this(credentials, new AmazonCostAndUsageReportConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCostAndUsageReportClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCostAndUsageReportClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCostAndUsageReportConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCostAndUsageReportClient with AWS Credentials and an
        /// AmazonCostAndUsageReportClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCostAndUsageReportClient Configuration Object</param>
        public AmazonCostAndUsageReportClient(AWSCredentials credentials, AmazonCostAndUsageReportConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCostAndUsageReportClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCostAndUsageReportClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCostAndUsageReportConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCostAndUsageReportClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCostAndUsageReportClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCostAndUsageReportConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCostAndUsageReportClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCostAndUsageReportClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCostAndUsageReportClient Configuration Object</param>
        public AmazonCostAndUsageReportClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCostAndUsageReportConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCostAndUsageReportClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCostAndUsageReportClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCostAndUsageReportConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCostAndUsageReportClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCostAndUsageReportClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCostAndUsageReportConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCostAndUsageReportClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCostAndUsageReportClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCostAndUsageReportClient Configuration Object</param>
        public AmazonCostAndUsageReportClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCostAndUsageReportConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ICostAndUsageReportPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ICostAndUsageReportPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new CostAndUsageReportPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
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


        #region  DeleteReportDefinition

        internal virtual DeleteReportDefinitionResponse DeleteReportDefinition(DeleteReportDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReportDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReportDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteReportDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReportDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteReportDefinition service method, as returned by CostAndUsageReport.</returns>
        /// <exception cref="Amazon.CostAndUsageReport.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostAndUsageReport.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cur-2017-01-06/DeleteReportDefinition">REST API Reference for DeleteReportDefinition Operation</seealso>
        public virtual Task<DeleteReportDefinitionResponse> DeleteReportDefinitionAsync(DeleteReportDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReportDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReportDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteReportDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReportDefinitions

        internal virtual DescribeReportDefinitionsResponse DescribeReportDefinitions(DescribeReportDefinitionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReportDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReportDefinitionsResponseUnmarshaller.Instance;

            return Invoke<DescribeReportDefinitionsResponse>(request, options);
        }



        /// <summary>
        /// Lists the AWS Cost and Usage reports available to this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReportDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReportDefinitions service method, as returned by CostAndUsageReport.</returns>
        /// <exception cref="Amazon.CostAndUsageReport.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cur-2017-01-06/DescribeReportDefinitions">REST API Reference for DescribeReportDefinitions Operation</seealso>
        public virtual Task<DescribeReportDefinitionsResponse> DescribeReportDefinitionsAsync(DescribeReportDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReportDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReportDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReportDefinitionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyReportDefinition

        internal virtual ModifyReportDefinitionResponse ModifyReportDefinition(ModifyReportDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyReportDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyReportDefinitionResponseUnmarshaller.Instance;

            return Invoke<ModifyReportDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Allows you to programatically update your report preferences.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyReportDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyReportDefinition service method, as returned by CostAndUsageReport.</returns>
        /// <exception cref="Amazon.CostAndUsageReport.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostAndUsageReport.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cur-2017-01-06/ModifyReportDefinition">REST API Reference for ModifyReportDefinition Operation</seealso>
        public virtual Task<ModifyReportDefinitionResponse> ModifyReportDefinitionAsync(ModifyReportDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyReportDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyReportDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyReportDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutReportDefinition

        internal virtual PutReportDefinitionResponse PutReportDefinition(PutReportDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutReportDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutReportDefinitionResponseUnmarshaller.Instance;

            return Invoke<PutReportDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Creates a new report using the description that you provide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutReportDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutReportDefinition service method, as returned by CostAndUsageReport.</returns>
        /// <exception cref="Amazon.CostAndUsageReport.Model.DuplicateReportNameException">
        /// A report with the specified name already exists in the account. Specify a different
        /// report name.
        /// </exception>
        /// <exception cref="Amazon.CostAndUsageReport.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostAndUsageReport.Model.ReportLimitReachedException">
        /// This account already has five reports defined. To define a new report, you must delete
        /// an existing report.
        /// </exception>
        /// <exception cref="Amazon.CostAndUsageReport.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cur-2017-01-06/PutReportDefinition">REST API Reference for PutReportDefinition Operation</seealso>
        public virtual Task<PutReportDefinitionResponse> PutReportDefinitionAsync(PutReportDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutReportDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutReportDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<PutReportDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}