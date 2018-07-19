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
 * Do not modify this file. This file is generated from the pi-2018-02-27.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.PI.Model;
using Amazon.PI.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.PI
{
    /// <summary>
    /// Implementation for accessing PI
    ///
    /// AWS Performance Insights enables you to monitor and explore different dimensions of
    /// database load based on data captured from a running RDS instance. The guide provides
    /// detailed information about Performance Insights data types, parameters and errors.
    /// For more information about Performance Insights capabilities see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_PerfInsights.html">Using
    /// Amazon RDS Performance Insights </a> in the <i>Amazon RDS User Guide</i>.
    /// 
    ///  
    /// <para>
    ///  The AWS Performance Insights API provides visibility into the performance of your
    /// RDS instance, when Performance Insights is enabled for supported engine types. While
    /// Amazon CloudWatch provides the authoritative source for AWS service vended monitoring
    /// metrics, AWS Performance Insights offers a domain-specific view of database load measured
    /// as Average Active Sessions and provided to API consumers as a 2-dimensional time-series
    /// dataset. The time dimension of the data provides DB load data for each time point
    /// in the queried time range, and each time point decomposes overall load in relation
    /// to the requested dimensions, such as SQL, Wait-event, User or Host, measured at that
    /// time point.
    /// </para>
    /// </summary>
    public partial class AmazonPIClient : AmazonServiceClient, IAmazonPI
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonPIClient with the credentials loaded from the application's
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
        public AmazonPIClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPIConfig()) { }

        /// <summary>
        /// Constructs AmazonPIClient with the credentials loaded from the application's
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
        public AmazonPIClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPIConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonPIClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonPIClient Configuration Object</param>
        public AmazonPIClient(AmazonPIConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonPIClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonPIClient(AWSCredentials credentials)
            : this(credentials, new AmazonPIConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPIClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPIClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonPIConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPIClient with AWS Credentials and an
        /// AmazonPIClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonPIClient Configuration Object</param>
        public AmazonPIClient(AWSCredentials credentials, AmazonPIConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPIClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonPIClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPIConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPIClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPIClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPIConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonPIClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPIClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonPIClient Configuration Object</param>
        public AmazonPIClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonPIConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPIClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonPIClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPIConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPIClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPIClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPIConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPIClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPIClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonPIClient Configuration Object</param>
        public AmazonPIClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonPIConfig clientConfig)
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

        
        #region  DescribeDimensionKeys

        /// <summary>
        /// For a specific time period, retrieve the top <code>N</code> dimension keys for a metric.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDimensionKeys service method.</param>
        /// 
        /// <returns>The response from the DescribeDimensionKeys service method, as returned by PI.</returns>
        /// <exception cref="Amazon.PI.Model.InternalServiceErrorException">
        /// The request failed due to an unknown error.
        /// </exception>
        /// <exception cref="Amazon.PI.Model.InvalidArgumentException">
        /// One of the arguments provided is invalid for this request.
        /// </exception>
        /// <exception cref="Amazon.PI.Model.NotAuthorizedException">
        /// The user is not authorized to perform this request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/DescribeDimensionKeys">REST API Reference for DescribeDimensionKeys Operation</seealso>
        public virtual DescribeDimensionKeysResponse DescribeDimensionKeys(DescribeDimensionKeysRequest request)
        {
            var marshaller = DescribeDimensionKeysRequestMarshaller.Instance;
            var unmarshaller = DescribeDimensionKeysResponseUnmarshaller.Instance;

            return Invoke<DescribeDimensionKeysRequest,DescribeDimensionKeysResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDimensionKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDimensionKeys operation on AmazonPIClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDimensionKeys
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/DescribeDimensionKeys">REST API Reference for DescribeDimensionKeys Operation</seealso>
        public virtual IAsyncResult BeginDescribeDimensionKeys(DescribeDimensionKeysRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeDimensionKeysRequestMarshaller.Instance;
            var unmarshaller = DescribeDimensionKeysResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeDimensionKeysRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDimensionKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDimensionKeys.</param>
        /// 
        /// <returns>Returns a  DescribeDimensionKeysResult from PI.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/DescribeDimensionKeys">REST API Reference for DescribeDimensionKeys Operation</seealso>
        public virtual DescribeDimensionKeysResponse EndDescribeDimensionKeys(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDimensionKeysResponse>(asyncResult);
        }

        #endregion
        
        #region  GetResourceMetrics

        /// <summary>
        /// Retrieve Performance Insights metrics for a set of data sources, over a time period.
        /// You can provide specific dimension groups and dimensions, and provide aggregation
        /// and filtering criteria for each group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceMetrics service method.</param>
        /// 
        /// <returns>The response from the GetResourceMetrics service method, as returned by PI.</returns>
        /// <exception cref="Amazon.PI.Model.InternalServiceErrorException">
        /// The request failed due to an unknown error.
        /// </exception>
        /// <exception cref="Amazon.PI.Model.InvalidArgumentException">
        /// One of the arguments provided is invalid for this request.
        /// </exception>
        /// <exception cref="Amazon.PI.Model.NotAuthorizedException">
        /// The user is not authorized to perform this request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/GetResourceMetrics">REST API Reference for GetResourceMetrics Operation</seealso>
        public virtual GetResourceMetricsResponse GetResourceMetrics(GetResourceMetricsRequest request)
        {
            var marshaller = GetResourceMetricsRequestMarshaller.Instance;
            var unmarshaller = GetResourceMetricsResponseUnmarshaller.Instance;

            return Invoke<GetResourceMetricsRequest,GetResourceMetricsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourceMetrics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourceMetrics operation on AmazonPIClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourceMetrics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/GetResourceMetrics">REST API Reference for GetResourceMetrics Operation</seealso>
        public virtual IAsyncResult BeginGetResourceMetrics(GetResourceMetricsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetResourceMetricsRequestMarshaller.Instance;
            var unmarshaller = GetResourceMetricsResponseUnmarshaller.Instance;

            return BeginInvoke<GetResourceMetricsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourceMetrics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourceMetrics.</param>
        /// 
        /// <returns>Returns a  GetResourceMetricsResult from PI.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pi-2018-02-27/GetResourceMetrics">REST API Reference for GetResourceMetrics Operation</seealso>
        public virtual GetResourceMetricsResponse EndGetResourceMetrics(IAsyncResult asyncResult)
        {
            return EndInvoke<GetResourceMetricsResponse>(asyncResult);
        }

        #endregion
        
    }
}