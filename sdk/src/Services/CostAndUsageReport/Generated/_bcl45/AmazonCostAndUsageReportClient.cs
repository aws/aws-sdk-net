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
 * Do not modify this file. This file is generated from the cur-2017-01-06.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.CostAndUsageReport.Model;
using Amazon.CostAndUsageReport.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CostAndUsageReport
{
    /// <summary>
    /// Implementation for accessing CostAndUsageReport
    ///
    /// All public APIs for AWS Cost and Usage Report service
    /// </summary>
    public partial class AmazonCostAndUsageReportClient : AmazonServiceClient, IAmazonCostAndUsageReport
    {
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

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
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


        /// <summary>
        /// Delete a specified report definition
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReportDefinition service method.</param>
        /// 
        /// <returns>The response from the DeleteReportDefinition service method, as returned by CostAndUsageReport.</returns>
        /// <exception cref="Amazon.CostAndUsageReport.Model.InternalErrorException">
        /// This exception is thrown on a known dependency failure.
        /// </exception>
        /// <exception cref="Amazon.CostAndUsageReport.Model.ValidationException">
        /// This exception is thrown when providing an invalid input. eg. Put a report preference
        /// with an invalid report name, or Delete a report preference with an empty report name.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cur-2017-01-06/DeleteReportDefinition">REST API Reference for DeleteReportDefinition Operation</seealso>
        public virtual DeleteReportDefinitionResponse DeleteReportDefinition(DeleteReportDefinitionRequest request)
        {
            var marshaller = DeleteReportDefinitionRequestMarshaller.Instance;
            var unmarshaller = DeleteReportDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteReportDefinitionRequest,DeleteReportDefinitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReportDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReportDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cur-2017-01-06/DeleteReportDefinition">REST API Reference for DeleteReportDefinition Operation</seealso>
        public virtual Task<DeleteReportDefinitionResponse> DeleteReportDefinitionAsync(DeleteReportDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteReportDefinitionRequestMarshaller.Instance;
            var unmarshaller = DeleteReportDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteReportDefinitionRequest,DeleteReportDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeReportDefinitions


        /// <summary>
        /// Describe a list of report definitions owned by the account
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReportDefinitions service method.</param>
        /// 
        /// <returns>The response from the DescribeReportDefinitions service method, as returned by CostAndUsageReport.</returns>
        /// <exception cref="Amazon.CostAndUsageReport.Model.InternalErrorException">
        /// This exception is thrown on a known dependency failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cur-2017-01-06/DescribeReportDefinitions">REST API Reference for DescribeReportDefinitions Operation</seealso>
        public virtual DescribeReportDefinitionsResponse DescribeReportDefinitions(DescribeReportDefinitionsRequest request)
        {
            var marshaller = DescribeReportDefinitionsRequestMarshaller.Instance;
            var unmarshaller = DescribeReportDefinitionsResponseUnmarshaller.Instance;

            return Invoke<DescribeReportDefinitionsRequest,DescribeReportDefinitionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReportDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReportDefinitions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cur-2017-01-06/DescribeReportDefinitions">REST API Reference for DescribeReportDefinitions Operation</seealso>
        public virtual Task<DescribeReportDefinitionsResponse> DescribeReportDefinitionsAsync(DescribeReportDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeReportDefinitionsRequestMarshaller.Instance;
            var unmarshaller = DescribeReportDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReportDefinitionsRequest,DescribeReportDefinitionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutReportDefinition


        /// <summary>
        /// Create a new report definition
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutReportDefinition service method.</param>
        /// 
        /// <returns>The response from the PutReportDefinition service method, as returned by CostAndUsageReport.</returns>
        /// <exception cref="Amazon.CostAndUsageReport.Model.DuplicateReportNameException">
        /// This exception is thrown when putting a report preference with a name that already
        /// exists.
        /// </exception>
        /// <exception cref="Amazon.CostAndUsageReport.Model.InternalErrorException">
        /// This exception is thrown on a known dependency failure.
        /// </exception>
        /// <exception cref="Amazon.CostAndUsageReport.Model.ReportLimitReachedException">
        /// This exception is thrown when the number of report preference reaches max limit. The
        /// max number is 5.
        /// </exception>
        /// <exception cref="Amazon.CostAndUsageReport.Model.ValidationException">
        /// This exception is thrown when providing an invalid input. eg. Put a report preference
        /// with an invalid report name, or Delete a report preference with an empty report name.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cur-2017-01-06/PutReportDefinition">REST API Reference for PutReportDefinition Operation</seealso>
        public virtual PutReportDefinitionResponse PutReportDefinition(PutReportDefinitionRequest request)
        {
            var marshaller = PutReportDefinitionRequestMarshaller.Instance;
            var unmarshaller = PutReportDefinitionResponseUnmarshaller.Instance;

            return Invoke<PutReportDefinitionRequest,PutReportDefinitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutReportDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutReportDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cur-2017-01-06/PutReportDefinition">REST API Reference for PutReportDefinition Operation</seealso>
        public virtual Task<PutReportDefinitionResponse> PutReportDefinitionAsync(PutReportDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutReportDefinitionRequestMarshaller.Instance;
            var unmarshaller = PutReportDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<PutReportDefinitionRequest,PutReportDefinitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}