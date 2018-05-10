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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.KinesisFirehose.Model;
using Amazon.KinesisFirehose.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.KinesisFirehose
{
    /// <summary>
    /// Implementation for accessing KinesisFirehose
    ///
    /// Amazon Kinesis Data Firehose API Reference 
    /// <para>
    /// Amazon Kinesis Data Firehose is a fully managed service that delivers real-time streaming
    /// data to destinations such as Amazon Simple Storage Service (Amazon S3), Amazon Elasticsearch
    /// Service (Amazon ES), Amazon Redshift, and Splunk.
    /// </para>
    /// </summary>
    public partial class AmazonKinesisFirehoseClient : AmazonServiceClient, IAmazonKinesisFirehose
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonKinesisFirehoseClient with the credentials loaded from the application's
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
        public AmazonKinesisFirehoseClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonKinesisFirehoseConfig()) { }

        /// <summary>
        /// Constructs AmazonKinesisFirehoseClient with the credentials loaded from the application's
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
        public AmazonKinesisFirehoseClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonKinesisFirehoseConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonKinesisFirehoseClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonKinesisFirehoseClient Configuration Object</param>
        public AmazonKinesisFirehoseClient(AmazonKinesisFirehoseConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonKinesisFirehoseClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonKinesisFirehoseClient(AWSCredentials credentials)
            : this(credentials, new AmazonKinesisFirehoseConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisFirehoseClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKinesisFirehoseClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonKinesisFirehoseConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisFirehoseClient with AWS Credentials and an
        /// AmazonKinesisFirehoseClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonKinesisFirehoseClient Configuration Object</param>
        public AmazonKinesisFirehoseClient(AWSCredentials credentials, AmazonKinesisFirehoseConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisFirehoseClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonKinesisFirehoseClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKinesisFirehoseConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisFirehoseClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKinesisFirehoseClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKinesisFirehoseConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisFirehoseClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKinesisFirehoseClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonKinesisFirehoseClient Configuration Object</param>
        public AmazonKinesisFirehoseClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonKinesisFirehoseConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisFirehoseClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonKinesisFirehoseClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKinesisFirehoseConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisFirehoseClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKinesisFirehoseClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKinesisFirehoseConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisFirehoseClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKinesisFirehoseClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonKinesisFirehoseClient Configuration Object</param>
        public AmazonKinesisFirehoseClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonKinesisFirehoseConfig clientConfig)
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

        
        #region  CreateDeliveryStream

        /// <summary>
        /// Creates a Kinesis Data Firehose delivery stream.
        /// 
        ///  
        /// <para>
        /// By default, you can create up to 50 delivery streams per AWS Region.
        /// </para>
        ///  
        /// <para>
        /// This is an asynchronous operation that immediately returns. The initial status of
        /// the delivery stream is <code>CREATING</code>. After the delivery stream is created,
        /// its status is <code>ACTIVE</code> and it now accepts data. Attempts to send data to
        /// a delivery stream that is not in the <code>ACTIVE</code> state cause an exception.
        /// To check the state of a delivery stream, use <a>DescribeDeliveryStream</a>.
        /// </para>
        ///  
        /// <para>
        /// A Kinesis Data Firehose delivery stream can be configured to receive records directly
        /// from providers using <a>PutRecord</a> or <a>PutRecordBatch</a>, or it can be configured
        /// to use an existing Kinesis stream as its source. To specify a Kinesis data stream
        /// as input, set the <code>DeliveryStreamType</code> parameter to <code>KinesisStreamAsSource</code>,
        /// and provide the Kinesis stream Amazon Resource Name (ARN) and role ARN in the <code>KinesisStreamSourceConfiguration</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// A delivery stream is configured with a single destination: Amazon S3, Amazon ES, Amazon
        /// Redshift, or Splunk. You must specify only one of the following destination configuration
        /// parameters: <b>ExtendedS3DestinationConfiguration</b>, <b>S3DestinationConfiguration</b>,
        /// <b>ElasticsearchDestinationConfiguration</b>, <b>RedshiftDestinationConfiguration</b>,
        /// or <b>SplunkDestinationConfiguration</b>.
        /// </para>
        ///  
        /// <para>
        /// When you specify <b>S3DestinationConfiguration</b>, you can also provide the following
        /// optional values: <b>BufferingHints</b>, <b>EncryptionConfiguration</b>, and <b>CompressionFormat</b>.
        /// By default, if no <b>BufferingHints</b> value is provided, Kinesis Data Firehose buffers
        /// data up to 5 MB or for 5 minutes, whichever condition is satisfied first. <b>BufferingHints</b>
        /// is a hint, so there are some cases where the service cannot adhere to these conditions
        /// strictly. For example, record boundaries might be such that the size is a little over
        /// or under the configured buffering size. By default, no encryption is performed. We
        /// strongly recommend that you enable encryption to ensure secure data storage in Amazon
        /// S3.
        /// </para>
        ///  
        /// <para>
        /// A few notes about Amazon Redshift as a destination:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An Amazon Redshift destination requires an S3 bucket as intermediate location. Kinesis
        /// Data Firehose first delivers data to Amazon S3 and then uses <code>COPY</code> syntax
        /// to load data into an Amazon Redshift table. This is specified in the <b>RedshiftDestinationConfiguration.S3Configuration</b>
        /// parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The compression formats <code>SNAPPY</code> or <code>ZIP</code> cannot be specified
        /// in <code>RedshiftDestinationConfiguration.S3Configuration</code> because the Amazon
        /// Redshift <code>COPY</code> operation that reads from the S3 bucket doesn't support
        /// these compression formats.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// We strongly recommend that you use the user name and password you provide exclusively
        /// with Kinesis Data Firehose, and that the permissions for the account are restricted
        /// for Amazon Redshift <code>INSERT</code> permissions.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Kinesis Data Firehose assumes the IAM role that is configured as part of the destination.
        /// The role should allow the Kinesis Data Firehose principal to assume the role, and
        /// the role should have permissions that allow the service to deliver the data. For more
        /// information, see <a href="http://docs.aws.amazon.com/firehose/latest/dev/controlling-access.html#using-iam-s3">Grant
        /// Kinesis Data Firehose Access to an Amazon S3 Destination</a> in the <i>Amazon Kinesis
        /// Data Firehose Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeliveryStream service method.</param>
        /// 
        /// <returns>The response from the CreateDeliveryStream service method, as returned by KinesisFirehose.</returns>
        /// <exception cref="Amazon.KinesisFirehose.Model.InvalidArgumentException">
        /// The specified input parameter has a value that is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.LimitExceededException">
        /// You have already reached the limit for a requested resource.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.ResourceInUseException">
        /// The resource is already in use and not available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/CreateDeliveryStream">REST API Reference for CreateDeliveryStream Operation</seealso>
        public virtual CreateDeliveryStreamResponse CreateDeliveryStream(CreateDeliveryStreamRequest request)
        {
            var marshaller = CreateDeliveryStreamRequestMarshaller.Instance;
            var unmarshaller = CreateDeliveryStreamResponseUnmarshaller.Instance;

            return Invoke<CreateDeliveryStreamRequest,CreateDeliveryStreamResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeliveryStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeliveryStream operation on AmazonKinesisFirehoseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDeliveryStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/CreateDeliveryStream">REST API Reference for CreateDeliveryStream Operation</seealso>
        public virtual IAsyncResult BeginCreateDeliveryStream(CreateDeliveryStreamRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateDeliveryStreamRequestMarshaller.Instance;
            var unmarshaller = CreateDeliveryStreamResponseUnmarshaller.Instance;

            return BeginInvoke<CreateDeliveryStreamRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDeliveryStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDeliveryStream.</param>
        /// 
        /// <returns>Returns a  CreateDeliveryStreamResult from KinesisFirehose.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/CreateDeliveryStream">REST API Reference for CreateDeliveryStream Operation</seealso>
        public virtual CreateDeliveryStreamResponse EndCreateDeliveryStream(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDeliveryStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDeliveryStream

        /// <summary>
        /// Deletes a delivery stream and its data.
        /// 
        ///  
        /// <para>
        /// You can delete a delivery stream only if it is in <code>ACTIVE</code> or <code>DELETING</code>
        /// state, and not in the <code>CREATING</code> state. While the deletion request is in
        /// process, the delivery stream is in the <code>DELETING</code> state.
        /// </para>
        ///  
        /// <para>
        /// To check the state of a delivery stream, use <a>DescribeDeliveryStream</a>.
        /// </para>
        ///  
        /// <para>
        /// While the delivery stream is <code>DELETING</code> state, the service might continue
        /// to accept the records, but it doesn't make any guarantees with respect to delivering
        /// the data. Therefore, as a best practice, you should first stop any applications that
        /// are sending records before deleting a delivery stream.
        /// </para>
        /// </summary>
        /// <param name="deliveryStreamName">The name of the delivery stream.</param>
        /// 
        /// <returns>The response from the DeleteDeliveryStream service method, as returned by KinesisFirehose.</returns>
        /// <exception cref="Amazon.KinesisFirehose.Model.ResourceInUseException">
        /// The resource is already in use and not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/DeleteDeliveryStream">REST API Reference for DeleteDeliveryStream Operation</seealso>
        public virtual DeleteDeliveryStreamResponse DeleteDeliveryStream(string deliveryStreamName)
        {
            var request = new DeleteDeliveryStreamRequest();
            request.DeliveryStreamName = deliveryStreamName;
            return DeleteDeliveryStream(request);
        }


        /// <summary>
        /// Deletes a delivery stream and its data.
        /// 
        ///  
        /// <para>
        /// You can delete a delivery stream only if it is in <code>ACTIVE</code> or <code>DELETING</code>
        /// state, and not in the <code>CREATING</code> state. While the deletion request is in
        /// process, the delivery stream is in the <code>DELETING</code> state.
        /// </para>
        ///  
        /// <para>
        /// To check the state of a delivery stream, use <a>DescribeDeliveryStream</a>.
        /// </para>
        ///  
        /// <para>
        /// While the delivery stream is <code>DELETING</code> state, the service might continue
        /// to accept the records, but it doesn't make any guarantees with respect to delivering
        /// the data. Therefore, as a best practice, you should first stop any applications that
        /// are sending records before deleting a delivery stream.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeliveryStream service method.</param>
        /// 
        /// <returns>The response from the DeleteDeliveryStream service method, as returned by KinesisFirehose.</returns>
        /// <exception cref="Amazon.KinesisFirehose.Model.ResourceInUseException">
        /// The resource is already in use and not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/DeleteDeliveryStream">REST API Reference for DeleteDeliveryStream Operation</seealso>
        public virtual DeleteDeliveryStreamResponse DeleteDeliveryStream(DeleteDeliveryStreamRequest request)
        {
            var marshaller = DeleteDeliveryStreamRequestMarshaller.Instance;
            var unmarshaller = DeleteDeliveryStreamResponseUnmarshaller.Instance;

            return Invoke<DeleteDeliveryStreamRequest,DeleteDeliveryStreamResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDeliveryStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeliveryStream operation on AmazonKinesisFirehoseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDeliveryStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/DeleteDeliveryStream">REST API Reference for DeleteDeliveryStream Operation</seealso>
        public virtual IAsyncResult BeginDeleteDeliveryStream(DeleteDeliveryStreamRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteDeliveryStreamRequestMarshaller.Instance;
            var unmarshaller = DeleteDeliveryStreamResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteDeliveryStreamRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDeliveryStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDeliveryStream.</param>
        /// 
        /// <returns>Returns a  DeleteDeliveryStreamResult from KinesisFirehose.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/DeleteDeliveryStream">REST API Reference for DeleteDeliveryStream Operation</seealso>
        public virtual DeleteDeliveryStreamResponse EndDeleteDeliveryStream(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDeliveryStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDeliveryStream

        /// <summary>
        /// Describes the specified delivery stream and gets the status. For example, after your
        /// delivery stream is created, call <code>DescribeDeliveryStream</code> to see whether
        /// the delivery stream is <code>ACTIVE</code> and therefore ready for data to be sent
        /// to it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeliveryStream service method.</param>
        /// 
        /// <returns>The response from the DescribeDeliveryStream service method, as returned by KinesisFirehose.</returns>
        /// <exception cref="Amazon.KinesisFirehose.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/DescribeDeliveryStream">REST API Reference for DescribeDeliveryStream Operation</seealso>
        public virtual DescribeDeliveryStreamResponse DescribeDeliveryStream(DescribeDeliveryStreamRequest request)
        {
            var marshaller = DescribeDeliveryStreamRequestMarshaller.Instance;
            var unmarshaller = DescribeDeliveryStreamResponseUnmarshaller.Instance;

            return Invoke<DescribeDeliveryStreamRequest,DescribeDeliveryStreamResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDeliveryStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeliveryStream operation on AmazonKinesisFirehoseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDeliveryStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/DescribeDeliveryStream">REST API Reference for DescribeDeliveryStream Operation</seealso>
        public virtual IAsyncResult BeginDescribeDeliveryStream(DescribeDeliveryStreamRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeDeliveryStreamRequestMarshaller.Instance;
            var unmarshaller = DescribeDeliveryStreamResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeDeliveryStreamRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDeliveryStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDeliveryStream.</param>
        /// 
        /// <returns>Returns a  DescribeDeliveryStreamResult from KinesisFirehose.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/DescribeDeliveryStream">REST API Reference for DescribeDeliveryStream Operation</seealso>
        public virtual DescribeDeliveryStreamResponse EndDescribeDeliveryStream(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDeliveryStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDeliveryStreams

        /// <summary>
        /// Lists your delivery streams.
        /// 
        ///  
        /// <para>
        /// The number of delivery streams might be too large to return using a single call to
        /// <code>ListDeliveryStreams</code>. You can limit the number of delivery streams returned,
        /// using the <b>Limit</b> parameter. To determine whether there are more delivery streams
        /// to list, check the value of <code>HasMoreDeliveryStreams</code> in the output. If
        /// there are more delivery streams to list, you can request them by specifying the name
        /// of the last delivery stream returned in the call in the <code>ExclusiveStartDeliveryStreamName</code>
        /// parameter of a subsequent call.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListDeliveryStreams service method, as returned by KinesisFirehose.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/ListDeliveryStreams">REST API Reference for ListDeliveryStreams Operation</seealso>
        public virtual ListDeliveryStreamsResponse ListDeliveryStreams()
        {
            return ListDeliveryStreams(new ListDeliveryStreamsRequest());
        }

        /// <summary>
        /// Lists your delivery streams.
        /// 
        ///  
        /// <para>
        /// The number of delivery streams might be too large to return using a single call to
        /// <code>ListDeliveryStreams</code>. You can limit the number of delivery streams returned,
        /// using the <b>Limit</b> parameter. To determine whether there are more delivery streams
        /// to list, check the value of <code>HasMoreDeliveryStreams</code> in the output. If
        /// there are more delivery streams to list, you can request them by specifying the name
        /// of the last delivery stream returned in the call in the <code>ExclusiveStartDeliveryStreamName</code>
        /// parameter of a subsequent call.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeliveryStreams service method.</param>
        /// 
        /// <returns>The response from the ListDeliveryStreams service method, as returned by KinesisFirehose.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/ListDeliveryStreams">REST API Reference for ListDeliveryStreams Operation</seealso>
        public virtual ListDeliveryStreamsResponse ListDeliveryStreams(ListDeliveryStreamsRequest request)
        {
            var marshaller = ListDeliveryStreamsRequestMarshaller.Instance;
            var unmarshaller = ListDeliveryStreamsResponseUnmarshaller.Instance;

            return Invoke<ListDeliveryStreamsRequest,ListDeliveryStreamsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeliveryStreams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeliveryStreams operation on AmazonKinesisFirehoseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDeliveryStreams
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/ListDeliveryStreams">REST API Reference for ListDeliveryStreams Operation</seealso>
        public virtual IAsyncResult BeginListDeliveryStreams(ListDeliveryStreamsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListDeliveryStreamsRequestMarshaller.Instance;
            var unmarshaller = ListDeliveryStreamsResponseUnmarshaller.Instance;

            return BeginInvoke<ListDeliveryStreamsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDeliveryStreams operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDeliveryStreams.</param>
        /// 
        /// <returns>Returns a  ListDeliveryStreamsResult from KinesisFirehose.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/ListDeliveryStreams">REST API Reference for ListDeliveryStreams Operation</seealso>
        public virtual ListDeliveryStreamsResponse EndListDeliveryStreams(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDeliveryStreamsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForDeliveryStream

        /// <summary>
        /// Lists the tags for the specified delivery stream. This operation has a limit of five
        /// transactions per second per account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForDeliveryStream service method.</param>
        /// 
        /// <returns>The response from the ListTagsForDeliveryStream service method, as returned by KinesisFirehose.</returns>
        /// <exception cref="Amazon.KinesisFirehose.Model.InvalidArgumentException">
        /// The specified input parameter has a value that is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.LimitExceededException">
        /// You have already reached the limit for a requested resource.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/ListTagsForDeliveryStream">REST API Reference for ListTagsForDeliveryStream Operation</seealso>
        public virtual ListTagsForDeliveryStreamResponse ListTagsForDeliveryStream(ListTagsForDeliveryStreamRequest request)
        {
            var marshaller = ListTagsForDeliveryStreamRequestMarshaller.Instance;
            var unmarshaller = ListTagsForDeliveryStreamResponseUnmarshaller.Instance;

            return Invoke<ListTagsForDeliveryStreamRequest,ListTagsForDeliveryStreamResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForDeliveryStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForDeliveryStream operation on AmazonKinesisFirehoseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForDeliveryStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/ListTagsForDeliveryStream">REST API Reference for ListTagsForDeliveryStream Operation</seealso>
        public virtual IAsyncResult BeginListTagsForDeliveryStream(ListTagsForDeliveryStreamRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListTagsForDeliveryStreamRequestMarshaller.Instance;
            var unmarshaller = ListTagsForDeliveryStreamResponseUnmarshaller.Instance;

            return BeginInvoke<ListTagsForDeliveryStreamRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForDeliveryStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForDeliveryStream.</param>
        /// 
        /// <returns>Returns a  ListTagsForDeliveryStreamResult from KinesisFirehose.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/ListTagsForDeliveryStream">REST API Reference for ListTagsForDeliveryStream Operation</seealso>
        public virtual ListTagsForDeliveryStreamResponse EndListTagsForDeliveryStream(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForDeliveryStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  PutRecord

        /// <summary>
        /// Writes a single data record into an Amazon Kinesis Data Firehose delivery stream.
        /// To write multiple data records into a delivery stream, use <a>PutRecordBatch</a>.
        /// Applications using these operations are referred to as producers.
        /// 
        ///  
        /// <para>
        /// By default, each delivery stream can take in up to 2,000 transactions per second,
        /// 5,000 records per second, or 5 MB per second. If you use <a>PutRecord</a> and <a>PutRecordBatch</a>,
        /// the limits are an aggregate across these two operations for each delivery stream.
        /// For more information about limits and how to request an increase, see <a href="http://docs.aws.amazon.com/firehose/latest/dev/limits.html">Amazon
        /// Kinesis Data Firehose Limits</a>. 
        /// </para>
        ///  
        /// <para>
        /// You must specify the name of the delivery stream and the data record when using <a>PutRecord</a>.
        /// The data record consists of a data blob that can be up to 1,000 KB in size, and any
        /// kind of data. For example, it can be a segment from a log file, geographic location
        /// data, website clickstream data, and so on.
        /// </para>
        ///  
        /// <para>
        /// Kinesis Data Firehose buffers records before delivering them to the destination. To
        /// disambiguate the data blobs at the destination, a common solution is to use delimiters
        /// in the data, such as a newline (<code>\n</code>) or some other character unique within
        /// the data. This allows the consumer application to parse individual data items when
        /// reading the data from the destination.
        /// </para>
        ///  
        /// <para>
        /// The <code>PutRecord</code> operation returns a <code>RecordId</code>, which is a unique
        /// string assigned to each record. Producer applications can use this ID for purposes
        /// such as auditability and investigation.
        /// </para>
        ///  
        /// <para>
        /// If the <code>PutRecord</code> operation throws a <code>ServiceUnavailableException</code>,
        /// back off and retry. If the exception persists, it is possible that the throughput
        /// limits have been exceeded for the delivery stream. 
        /// </para>
        ///  
        /// <para>
        /// Data records sent to Kinesis Data Firehose are stored for 24 hours from the time they
        /// are added to a delivery stream as it tries to send the records to the destination.
        /// If the destination is unreachable for more than 24 hours, the data is no longer available.
        /// </para>
        /// </summary>
        /// <param name="deliveryStreamName">The name of the delivery stream.</param>
        /// <param name="record">The record.</param>
        /// 
        /// <returns>The response from the PutRecord service method, as returned by KinesisFirehose.</returns>
        /// <exception cref="Amazon.KinesisFirehose.Model.InvalidArgumentException">
        /// The specified input parameter has a value that is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.ServiceUnavailableException">
        /// The service is unavailable. Back off and retry the operation. If you continue to see
        /// the exception, throughput limits for the delivery stream may have been exceeded. For
        /// more information about limits and how to request an increase, see <a href="http://docs.aws.amazon.com/firehose/latest/dev/limits.html">Amazon
        /// Kinesis Data Firehose Limits</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/PutRecord">REST API Reference for PutRecord Operation</seealso>
        public virtual PutRecordResponse PutRecord(string deliveryStreamName, Record record)
        {
            var request = new PutRecordRequest();
            request.DeliveryStreamName = deliveryStreamName;
            request.Record = record;
            return PutRecord(request);
        }


        /// <summary>
        /// Writes a single data record into an Amazon Kinesis Data Firehose delivery stream.
        /// To write multiple data records into a delivery stream, use <a>PutRecordBatch</a>.
        /// Applications using these operations are referred to as producers.
        /// 
        ///  
        /// <para>
        /// By default, each delivery stream can take in up to 2,000 transactions per second,
        /// 5,000 records per second, or 5 MB per second. If you use <a>PutRecord</a> and <a>PutRecordBatch</a>,
        /// the limits are an aggregate across these two operations for each delivery stream.
        /// For more information about limits and how to request an increase, see <a href="http://docs.aws.amazon.com/firehose/latest/dev/limits.html">Amazon
        /// Kinesis Data Firehose Limits</a>. 
        /// </para>
        ///  
        /// <para>
        /// You must specify the name of the delivery stream and the data record when using <a>PutRecord</a>.
        /// The data record consists of a data blob that can be up to 1,000 KB in size, and any
        /// kind of data. For example, it can be a segment from a log file, geographic location
        /// data, website clickstream data, and so on.
        /// </para>
        ///  
        /// <para>
        /// Kinesis Data Firehose buffers records before delivering them to the destination. To
        /// disambiguate the data blobs at the destination, a common solution is to use delimiters
        /// in the data, such as a newline (<code>\n</code>) or some other character unique within
        /// the data. This allows the consumer application to parse individual data items when
        /// reading the data from the destination.
        /// </para>
        ///  
        /// <para>
        /// The <code>PutRecord</code> operation returns a <code>RecordId</code>, which is a unique
        /// string assigned to each record. Producer applications can use this ID for purposes
        /// such as auditability and investigation.
        /// </para>
        ///  
        /// <para>
        /// If the <code>PutRecord</code> operation throws a <code>ServiceUnavailableException</code>,
        /// back off and retry. If the exception persists, it is possible that the throughput
        /// limits have been exceeded for the delivery stream. 
        /// </para>
        ///  
        /// <para>
        /// Data records sent to Kinesis Data Firehose are stored for 24 hours from the time they
        /// are added to a delivery stream as it tries to send the records to the destination.
        /// If the destination is unreachable for more than 24 hours, the data is no longer available.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRecord service method.</param>
        /// 
        /// <returns>The response from the PutRecord service method, as returned by KinesisFirehose.</returns>
        /// <exception cref="Amazon.KinesisFirehose.Model.InvalidArgumentException">
        /// The specified input parameter has a value that is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.ServiceUnavailableException">
        /// The service is unavailable. Back off and retry the operation. If you continue to see
        /// the exception, throughput limits for the delivery stream may have been exceeded. For
        /// more information about limits and how to request an increase, see <a href="http://docs.aws.amazon.com/firehose/latest/dev/limits.html">Amazon
        /// Kinesis Data Firehose Limits</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/PutRecord">REST API Reference for PutRecord Operation</seealso>
        public virtual PutRecordResponse PutRecord(PutRecordRequest request)
        {
            var marshaller = PutRecordRequestMarshaller.Instance;
            var unmarshaller = PutRecordResponseUnmarshaller.Instance;

            return Invoke<PutRecordRequest,PutRecordResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutRecord operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRecord operation on AmazonKinesisFirehoseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutRecord
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/PutRecord">REST API Reference for PutRecord Operation</seealso>
        public virtual IAsyncResult BeginPutRecord(PutRecordRequest request, AsyncCallback callback, object state)
        {
            var marshaller = PutRecordRequestMarshaller.Instance;
            var unmarshaller = PutRecordResponseUnmarshaller.Instance;

            return BeginInvoke<PutRecordRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutRecord operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRecord.</param>
        /// 
        /// <returns>Returns a  PutRecordResult from KinesisFirehose.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/PutRecord">REST API Reference for PutRecord Operation</seealso>
        public virtual PutRecordResponse EndPutRecord(IAsyncResult asyncResult)
        {
            return EndInvoke<PutRecordResponse>(asyncResult);
        }

        #endregion
        
        #region  PutRecordBatch

        /// <summary>
        /// Writes multiple data records into a delivery stream in a single call, which can achieve
        /// higher throughput per producer than when writing single records. To write single data
        /// records into a delivery stream, use <a>PutRecord</a>. Applications using these operations
        /// are referred to as producers.
        /// 
        ///  
        /// <para>
        /// By default, each delivery stream can take in up to 2,000 transactions per second,
        /// 5,000 records per second, or 5 MB per second. If you use <a>PutRecord</a> and <a>PutRecordBatch</a>,
        /// the limits are an aggregate across these two operations for each delivery stream.
        /// For more information about limits, see <a href="http://docs.aws.amazon.com/firehose/latest/dev/limits.html">Amazon
        /// Kinesis Data Firehose Limits</a>.
        /// </para>
        ///  
        /// <para>
        /// Each <a>PutRecordBatch</a> request supports up to 500 records. Each record in the
        /// request can be as large as 1,000 KB (before 64-bit encoding), up to a limit of 4 MB
        /// for the entire request. These limits cannot be changed.
        /// </para>
        ///  
        /// <para>
        /// You must specify the name of the delivery stream and the data record when using <a>PutRecord</a>.
        /// The data record consists of a data blob that can be up to 1,000 KB in size, and any
        /// kind of data. For example, it could be a segment from a log file, geographic location
        /// data, website clickstream data, and so on.
        /// </para>
        ///  
        /// <para>
        /// Kinesis Data Firehose buffers records before delivering them to the destination. To
        /// disambiguate the data blobs at the destination, a common solution is to use delimiters
        /// in the data, such as a newline (<code>\n</code>) or some other character unique within
        /// the data. This allows the consumer application to parse individual data items when
        /// reading the data from the destination.
        /// </para>
        ///  
        /// <para>
        /// The <a>PutRecordBatch</a> response includes a count of failed records, <b>FailedPutCount</b>,
        /// and an array of responses, <b>RequestResponses</b>. Each entry in the <b>RequestResponses</b>
        /// array provides additional information about the processed record. It directly correlates
        /// with a record in the request array using the same ordering, from the top to the bottom.
        /// The response array always includes the same number of records as the request array.
        /// <b>RequestResponses</b> includes both successfully and unsuccessfully processed records.
        /// Kinesis Data Firehose tries to process all records in each <a>PutRecordBatch</a> request.
        /// A single record failure does not stop the processing of subsequent records.
        /// </para>
        ///  
        /// <para>
        /// A successfully processed record includes a <b>RecordId</b> value, which is unique
        /// for the record. An unsuccessfully processed record includes <b>ErrorCode</b> and <b>ErrorMessage</b>
        /// values. <b>ErrorCode</b> reflects the type of error, and is one of the following values:
        /// <code>ServiceUnavailable</code> or <code>InternalFailure</code>. <b>ErrorMessage</b>
        /// provides more detailed information about the error.
        /// </para>
        ///  
        /// <para>
        /// If there is an internal server error or a timeout, the write might have completed
        /// or it might have failed. If <b>FailedPutCount</b> is greater than 0, retry the request,
        /// resending only those records that might have failed processing. This minimizes the
        /// possible duplicate records and also reduces the total bytes sent (and corresponding
        /// charges). We recommend that you handle any duplicates at the destination.
        /// </para>
        ///  
        /// <para>
        /// If <a>PutRecordBatch</a> throws <b>ServiceUnavailableException</b>, back off and retry.
        /// If the exception persists, it is possible that the throughput limits have been exceeded
        /// for the delivery stream.
        /// </para>
        ///  
        /// <para>
        /// Data records sent to Kinesis Data Firehose are stored for 24 hours from the time they
        /// are added to a delivery stream as it attempts to send the records to the destination.
        /// If the destination is unreachable for more than 24 hours, the data is no longer available.
        /// </para>
        /// </summary>
        /// <param name="deliveryStreamName">The name of the delivery stream.</param>
        /// <param name="records">One or more records.</param>
        /// 
        /// <returns>The response from the PutRecordBatch service method, as returned by KinesisFirehose.</returns>
        /// <exception cref="Amazon.KinesisFirehose.Model.InvalidArgumentException">
        /// The specified input parameter has a value that is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.ServiceUnavailableException">
        /// The service is unavailable. Back off and retry the operation. If you continue to see
        /// the exception, throughput limits for the delivery stream may have been exceeded. For
        /// more information about limits and how to request an increase, see <a href="http://docs.aws.amazon.com/firehose/latest/dev/limits.html">Amazon
        /// Kinesis Data Firehose Limits</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/PutRecordBatch">REST API Reference for PutRecordBatch Operation</seealso>
        public virtual PutRecordBatchResponse PutRecordBatch(string deliveryStreamName, List<Record> records)
        {
            var request = new PutRecordBatchRequest();
            request.DeliveryStreamName = deliveryStreamName;
            request.Records = records;
            return PutRecordBatch(request);
        }


        /// <summary>
        /// Writes multiple data records into a delivery stream in a single call, which can achieve
        /// higher throughput per producer than when writing single records. To write single data
        /// records into a delivery stream, use <a>PutRecord</a>. Applications using these operations
        /// are referred to as producers.
        /// 
        ///  
        /// <para>
        /// By default, each delivery stream can take in up to 2,000 transactions per second,
        /// 5,000 records per second, or 5 MB per second. If you use <a>PutRecord</a> and <a>PutRecordBatch</a>,
        /// the limits are an aggregate across these two operations for each delivery stream.
        /// For more information about limits, see <a href="http://docs.aws.amazon.com/firehose/latest/dev/limits.html">Amazon
        /// Kinesis Data Firehose Limits</a>.
        /// </para>
        ///  
        /// <para>
        /// Each <a>PutRecordBatch</a> request supports up to 500 records. Each record in the
        /// request can be as large as 1,000 KB (before 64-bit encoding), up to a limit of 4 MB
        /// for the entire request. These limits cannot be changed.
        /// </para>
        ///  
        /// <para>
        /// You must specify the name of the delivery stream and the data record when using <a>PutRecord</a>.
        /// The data record consists of a data blob that can be up to 1,000 KB in size, and any
        /// kind of data. For example, it could be a segment from a log file, geographic location
        /// data, website clickstream data, and so on.
        /// </para>
        ///  
        /// <para>
        /// Kinesis Data Firehose buffers records before delivering them to the destination. To
        /// disambiguate the data blobs at the destination, a common solution is to use delimiters
        /// in the data, such as a newline (<code>\n</code>) or some other character unique within
        /// the data. This allows the consumer application to parse individual data items when
        /// reading the data from the destination.
        /// </para>
        ///  
        /// <para>
        /// The <a>PutRecordBatch</a> response includes a count of failed records, <b>FailedPutCount</b>,
        /// and an array of responses, <b>RequestResponses</b>. Each entry in the <b>RequestResponses</b>
        /// array provides additional information about the processed record. It directly correlates
        /// with a record in the request array using the same ordering, from the top to the bottom.
        /// The response array always includes the same number of records as the request array.
        /// <b>RequestResponses</b> includes both successfully and unsuccessfully processed records.
        /// Kinesis Data Firehose tries to process all records in each <a>PutRecordBatch</a> request.
        /// A single record failure does not stop the processing of subsequent records.
        /// </para>
        ///  
        /// <para>
        /// A successfully processed record includes a <b>RecordId</b> value, which is unique
        /// for the record. An unsuccessfully processed record includes <b>ErrorCode</b> and <b>ErrorMessage</b>
        /// values. <b>ErrorCode</b> reflects the type of error, and is one of the following values:
        /// <code>ServiceUnavailable</code> or <code>InternalFailure</code>. <b>ErrorMessage</b>
        /// provides more detailed information about the error.
        /// </para>
        ///  
        /// <para>
        /// If there is an internal server error or a timeout, the write might have completed
        /// or it might have failed. If <b>FailedPutCount</b> is greater than 0, retry the request,
        /// resending only those records that might have failed processing. This minimizes the
        /// possible duplicate records and also reduces the total bytes sent (and corresponding
        /// charges). We recommend that you handle any duplicates at the destination.
        /// </para>
        ///  
        /// <para>
        /// If <a>PutRecordBatch</a> throws <b>ServiceUnavailableException</b>, back off and retry.
        /// If the exception persists, it is possible that the throughput limits have been exceeded
        /// for the delivery stream.
        /// </para>
        ///  
        /// <para>
        /// Data records sent to Kinesis Data Firehose are stored for 24 hours from the time they
        /// are added to a delivery stream as it attempts to send the records to the destination.
        /// If the destination is unreachable for more than 24 hours, the data is no longer available.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRecordBatch service method.</param>
        /// 
        /// <returns>The response from the PutRecordBatch service method, as returned by KinesisFirehose.</returns>
        /// <exception cref="Amazon.KinesisFirehose.Model.InvalidArgumentException">
        /// The specified input parameter has a value that is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.ServiceUnavailableException">
        /// The service is unavailable. Back off and retry the operation. If you continue to see
        /// the exception, throughput limits for the delivery stream may have been exceeded. For
        /// more information about limits and how to request an increase, see <a href="http://docs.aws.amazon.com/firehose/latest/dev/limits.html">Amazon
        /// Kinesis Data Firehose Limits</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/PutRecordBatch">REST API Reference for PutRecordBatch Operation</seealso>
        public virtual PutRecordBatchResponse PutRecordBatch(PutRecordBatchRequest request)
        {
            var marshaller = PutRecordBatchRequestMarshaller.Instance;
            var unmarshaller = PutRecordBatchResponseUnmarshaller.Instance;

            return Invoke<PutRecordBatchRequest,PutRecordBatchResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutRecordBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRecordBatch operation on AmazonKinesisFirehoseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutRecordBatch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/PutRecordBatch">REST API Reference for PutRecordBatch Operation</seealso>
        public virtual IAsyncResult BeginPutRecordBatch(PutRecordBatchRequest request, AsyncCallback callback, object state)
        {
            var marshaller = PutRecordBatchRequestMarshaller.Instance;
            var unmarshaller = PutRecordBatchResponseUnmarshaller.Instance;

            return BeginInvoke<PutRecordBatchRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutRecordBatch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRecordBatch.</param>
        /// 
        /// <returns>Returns a  PutRecordBatchResult from KinesisFirehose.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/PutRecordBatch">REST API Reference for PutRecordBatch Operation</seealso>
        public virtual PutRecordBatchResponse EndPutRecordBatch(IAsyncResult asyncResult)
        {
            return EndInvoke<PutRecordBatchResponse>(asyncResult);
        }

        #endregion
        
        #region  TagDeliveryStream

        /// <summary>
        /// Adds or updates tags for the specified delivery stream. A tag is a key-value pair
        /// (the value is optional) that you can define and assign to AWS resources. If you specify
        /// a tag that already exists, the tag value is replaced with the value that you specify
        /// in the request. Tags are metadata. For example, you can add friendly names and descriptions
        /// or other types of information that can help you distinguish the delivery stream. For
        /// more information about tags, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html">Using
        /// Cost Allocation Tags</a> in the <i>AWS Billing and Cost Management User Guide</i>.
        /// 
        /// 
        ///  
        /// <para>
        ///  Each delivery stream can have up to 50 tags. 
        /// </para>
        ///  
        /// <para>
        ///  This operation has a limit of five transactions per second per account. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagDeliveryStream service method.</param>
        /// 
        /// <returns>The response from the TagDeliveryStream service method, as returned by KinesisFirehose.</returns>
        /// <exception cref="Amazon.KinesisFirehose.Model.InvalidArgumentException">
        /// The specified input parameter has a value that is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.LimitExceededException">
        /// You have already reached the limit for a requested resource.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.ResourceInUseException">
        /// The resource is already in use and not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/TagDeliveryStream">REST API Reference for TagDeliveryStream Operation</seealso>
        public virtual TagDeliveryStreamResponse TagDeliveryStream(TagDeliveryStreamRequest request)
        {
            var marshaller = TagDeliveryStreamRequestMarshaller.Instance;
            var unmarshaller = TagDeliveryStreamResponseUnmarshaller.Instance;

            return Invoke<TagDeliveryStreamRequest,TagDeliveryStreamResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagDeliveryStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagDeliveryStream operation on AmazonKinesisFirehoseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagDeliveryStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/TagDeliveryStream">REST API Reference for TagDeliveryStream Operation</seealso>
        public virtual IAsyncResult BeginTagDeliveryStream(TagDeliveryStreamRequest request, AsyncCallback callback, object state)
        {
            var marshaller = TagDeliveryStreamRequestMarshaller.Instance;
            var unmarshaller = TagDeliveryStreamResponseUnmarshaller.Instance;

            return BeginInvoke<TagDeliveryStreamRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagDeliveryStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagDeliveryStream.</param>
        /// 
        /// <returns>Returns a  TagDeliveryStreamResult from KinesisFirehose.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/TagDeliveryStream">REST API Reference for TagDeliveryStream Operation</seealso>
        public virtual TagDeliveryStreamResponse EndTagDeliveryStream(IAsyncResult asyncResult)
        {
            return EndInvoke<TagDeliveryStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagDeliveryStream

        /// <summary>
        /// Removes tags from the specified delivery stream. Removed tags are deleted, and you
        /// can't recover them after this operation successfully completes.
        /// 
        ///  
        /// <para>
        /// If you specify a tag that doesn't exist, the operation ignores it.
        /// </para>
        ///  
        /// <para>
        /// This operation has a limit of five transactions per second per account. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagDeliveryStream service method.</param>
        /// 
        /// <returns>The response from the UntagDeliveryStream service method, as returned by KinesisFirehose.</returns>
        /// <exception cref="Amazon.KinesisFirehose.Model.InvalidArgumentException">
        /// The specified input parameter has a value that is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.LimitExceededException">
        /// You have already reached the limit for a requested resource.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.ResourceInUseException">
        /// The resource is already in use and not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/UntagDeliveryStream">REST API Reference for UntagDeliveryStream Operation</seealso>
        public virtual UntagDeliveryStreamResponse UntagDeliveryStream(UntagDeliveryStreamRequest request)
        {
            var marshaller = UntagDeliveryStreamRequestMarshaller.Instance;
            var unmarshaller = UntagDeliveryStreamResponseUnmarshaller.Instance;

            return Invoke<UntagDeliveryStreamRequest,UntagDeliveryStreamResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagDeliveryStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagDeliveryStream operation on AmazonKinesisFirehoseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagDeliveryStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/UntagDeliveryStream">REST API Reference for UntagDeliveryStream Operation</seealso>
        public virtual IAsyncResult BeginUntagDeliveryStream(UntagDeliveryStreamRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UntagDeliveryStreamRequestMarshaller.Instance;
            var unmarshaller = UntagDeliveryStreamResponseUnmarshaller.Instance;

            return BeginInvoke<UntagDeliveryStreamRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagDeliveryStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagDeliveryStream.</param>
        /// 
        /// <returns>Returns a  UntagDeliveryStreamResult from KinesisFirehose.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/UntagDeliveryStream">REST API Reference for UntagDeliveryStream Operation</seealso>
        public virtual UntagDeliveryStreamResponse EndUntagDeliveryStream(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagDeliveryStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDestination

        /// <summary>
        /// Updates the specified destination of the specified delivery stream.
        /// 
        ///  
        /// <para>
        /// Use this operation to change the destination type (for example, to replace the Amazon
        /// S3 destination with Amazon Redshift) or change the parameters associated with a destination
        /// (for example, to change the bucket name of the Amazon S3 destination). The update
        /// might not occur immediately. The target delivery stream remains active while the configurations
        /// are updated, so data writes to the delivery stream can continue during this process.
        /// The updated configurations are usually effective within a few minutes.
        /// </para>
        ///  
        /// <para>
        /// Switching between Amazon ES and other services is not supported. For an Amazon ES
        /// destination, you can only update to another Amazon ES destination.
        /// </para>
        ///  
        /// <para>
        /// If the destination type is the same, Kinesis Data Firehose merges the configuration
        /// parameters specified with the destination configuration that already exists on the
        /// delivery stream. If any of the parameters are not specified in the call, the existing
        /// values are retained. For example, in the Amazon S3 destination, if <a>EncryptionConfiguration</a>
        /// is not specified, then the existing <code>EncryptionConfiguration</code> is maintained
        /// on the destination.
        /// </para>
        ///  
        /// <para>
        /// If the destination type is not the same, for example, changing the destination from
        /// Amazon S3 to Amazon Redshift, Kinesis Data Firehose does not merge any parameters.
        /// In this case, all parameters must be specified.
        /// </para>
        ///  
        /// <para>
        /// Kinesis Data Firehose uses <b>CurrentDeliveryStreamVersionId</b> to avoid race conditions
        /// and conflicting merges. This is a required field, and the service updates the configuration
        /// only if the existing configuration has a version ID that matches. After the update
        /// is applied successfully, the version ID is updated, and can be retrieved using <a>DescribeDeliveryStream</a>.
        /// Use the new version ID to set <b>CurrentDeliveryStreamVersionId</b> in the next call.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDestination service method.</param>
        /// 
        /// <returns>The response from the UpdateDestination service method, as returned by KinesisFirehose.</returns>
        /// <exception cref="Amazon.KinesisFirehose.Model.ConcurrentModificationException">
        /// Another modification has already happened. Fetch <b>VersionId</b> again and use it
        /// to update the destination.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.InvalidArgumentException">
        /// The specified input parameter has a value that is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.ResourceInUseException">
        /// The resource is already in use and not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/UpdateDestination">REST API Reference for UpdateDestination Operation</seealso>
        public virtual UpdateDestinationResponse UpdateDestination(UpdateDestinationRequest request)
        {
            var marshaller = UpdateDestinationRequestMarshaller.Instance;
            var unmarshaller = UpdateDestinationResponseUnmarshaller.Instance;

            return Invoke<UpdateDestinationRequest,UpdateDestinationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDestination operation on AmazonKinesisFirehoseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/UpdateDestination">REST API Reference for UpdateDestination Operation</seealso>
        public virtual IAsyncResult BeginUpdateDestination(UpdateDestinationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateDestinationRequestMarshaller.Instance;
            var unmarshaller = UpdateDestinationResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateDestinationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDestination.</param>
        /// 
        /// <returns>Returns a  UpdateDestinationResult from KinesisFirehose.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/UpdateDestination">REST API Reference for UpdateDestination Operation</seealso>
        public virtual UpdateDestinationResponse EndUpdateDestination(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDestinationResponse>(asyncResult);
        }

        #endregion
        
    }
}