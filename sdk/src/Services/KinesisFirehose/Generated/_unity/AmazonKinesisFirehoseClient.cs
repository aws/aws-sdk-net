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
        /// Initiates the asynchronous execution of the CreateDeliveryStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeliveryStream operation on AmazonKinesisFirehoseClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/CreateDeliveryStream">REST API Reference for CreateDeliveryStream Operation</seealso>
        public virtual void CreateDeliveryStreamAsync(CreateDeliveryStreamRequest request, AmazonServiceCallback<CreateDeliveryStreamRequest, CreateDeliveryStreamResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = CreateDeliveryStreamRequestMarshaller.Instance;
            var unmarshaller = CreateDeliveryStreamResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateDeliveryStreamRequest,CreateDeliveryStreamResponse> responseObject 
                            = new AmazonServiceResult<CreateDeliveryStreamRequest,CreateDeliveryStreamResponse>((CreateDeliveryStreamRequest)req, (CreateDeliveryStreamResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<CreateDeliveryStreamRequest>(request, marshaller, unmarshaller, options, callbackHelper);
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
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDeliveryStream service method, as returned by KinesisFirehose.</returns>
        /// <exception cref="Amazon.KinesisFirehose.Model.ResourceInUseException">
        /// The resource is already in use and not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisFirehose.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/DeleteDeliveryStream">REST API Reference for DeleteDeliveryStream Operation</seealso>
        public virtual void DeleteDeliveryStreamAsync(string deliveryStreamName,  AmazonServiceCallback<DeleteDeliveryStreamRequest, DeleteDeliveryStreamResponse> callback, AsyncOptions options = null)
        {
            var request = new DeleteDeliveryStreamRequest();
            request.DeliveryStreamName = deliveryStreamName;
            DeleteDeliveryStreamAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDeliveryStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeliveryStream operation on AmazonKinesisFirehoseClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/DeleteDeliveryStream">REST API Reference for DeleteDeliveryStream Operation</seealso>
        public virtual void DeleteDeliveryStreamAsync(DeleteDeliveryStreamRequest request, AmazonServiceCallback<DeleteDeliveryStreamRequest, DeleteDeliveryStreamResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = DeleteDeliveryStreamRequestMarshaller.Instance;
            var unmarshaller = DeleteDeliveryStreamResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteDeliveryStreamRequest,DeleteDeliveryStreamResponse> responseObject 
                            = new AmazonServiceResult<DeleteDeliveryStreamRequest,DeleteDeliveryStreamResponse>((DeleteDeliveryStreamRequest)req, (DeleteDeliveryStreamResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DeleteDeliveryStreamRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  DescribeDeliveryStream

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDeliveryStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeliveryStream operation on AmazonKinesisFirehoseClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/DescribeDeliveryStream">REST API Reference for DescribeDeliveryStream Operation</seealso>
        public virtual void DescribeDeliveryStreamAsync(DescribeDeliveryStreamRequest request, AmazonServiceCallback<DescribeDeliveryStreamRequest, DescribeDeliveryStreamResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = DescribeDeliveryStreamRequestMarshaller.Instance;
            var unmarshaller = DescribeDeliveryStreamResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DescribeDeliveryStreamRequest,DescribeDeliveryStreamResponse> responseObject 
                            = new AmazonServiceResult<DescribeDeliveryStreamRequest,DescribeDeliveryStreamResponse>((DescribeDeliveryStreamRequest)req, (DescribeDeliveryStreamResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<DescribeDeliveryStreamRequest>(request, marshaller, unmarshaller, options, callbackHelper);
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
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
         
         /// <param name="options">
         ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
         ///     procedure using the AsyncState property.
         /// </param>
        /// 
        /// <returns>The response from the ListDeliveryStreams service method, as returned by KinesisFirehose.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/ListDeliveryStreams">REST API Reference for ListDeliveryStreams Operation</seealso>
        public virtual void ListDeliveryStreamsAsync(AmazonServiceCallback<ListDeliveryStreamsRequest, ListDeliveryStreamsResponse> callback, AsyncOptions options = null)
        {
            ListDeliveryStreamsAsync(new ListDeliveryStreamsRequest(), callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListDeliveryStreams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeliveryStreams operation on AmazonKinesisFirehoseClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/ListDeliveryStreams">REST API Reference for ListDeliveryStreams Operation</seealso>
        public virtual void ListDeliveryStreamsAsync(ListDeliveryStreamsRequest request, AmazonServiceCallback<ListDeliveryStreamsRequest, ListDeliveryStreamsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = ListDeliveryStreamsRequestMarshaller.Instance;
            var unmarshaller = ListDeliveryStreamsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListDeliveryStreamsRequest,ListDeliveryStreamsResponse> responseObject 
                            = new AmazonServiceResult<ListDeliveryStreamsRequest,ListDeliveryStreamsResponse>((ListDeliveryStreamsRequest)req, (ListDeliveryStreamsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<ListDeliveryStreamsRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  ListTagsForDeliveryStream

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForDeliveryStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForDeliveryStream operation on AmazonKinesisFirehoseClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/ListTagsForDeliveryStream">REST API Reference for ListTagsForDeliveryStream Operation</seealso>
        public virtual void ListTagsForDeliveryStreamAsync(ListTagsForDeliveryStreamRequest request, AmazonServiceCallback<ListTagsForDeliveryStreamRequest, ListTagsForDeliveryStreamResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = ListTagsForDeliveryStreamRequestMarshaller.Instance;
            var unmarshaller = ListTagsForDeliveryStreamResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListTagsForDeliveryStreamRequest,ListTagsForDeliveryStreamResponse> responseObject 
                            = new AmazonServiceResult<ListTagsForDeliveryStreamRequest,ListTagsForDeliveryStreamResponse>((ListTagsForDeliveryStreamRequest)req, (ListTagsForDeliveryStreamResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<ListTagsForDeliveryStreamRequest>(request, marshaller, unmarshaller, options, callbackHelper);
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
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
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
        public virtual void PutRecordAsync(string deliveryStreamName, Record record,  AmazonServiceCallback<PutRecordRequest, PutRecordResponse> callback, AsyncOptions options = null)
        {
            var request = new PutRecordRequest();
            request.DeliveryStreamName = deliveryStreamName;
            request.Record = record;
            PutRecordAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutRecord operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRecord operation on AmazonKinesisFirehoseClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/PutRecord">REST API Reference for PutRecord Operation</seealso>
        public virtual void PutRecordAsync(PutRecordRequest request, AmazonServiceCallback<PutRecordRequest, PutRecordResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = PutRecordRequestMarshaller.Instance;
            var unmarshaller = PutRecordResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutRecordRequest,PutRecordResponse> responseObject 
                            = new AmazonServiceResult<PutRecordRequest,PutRecordResponse>((PutRecordRequest)req, (PutRecordResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<PutRecordRequest>(request, marshaller, unmarshaller, options, callbackHelper);
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
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
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
        public virtual void PutRecordBatchAsync(string deliveryStreamName, List<Record> records,  AmazonServiceCallback<PutRecordBatchRequest, PutRecordBatchResponse> callback, AsyncOptions options = null)
        {
            var request = new PutRecordBatchRequest();
            request.DeliveryStreamName = deliveryStreamName;
            request.Records = records;
            PutRecordBatchAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutRecordBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRecordBatch operation on AmazonKinesisFirehoseClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/PutRecordBatch">REST API Reference for PutRecordBatch Operation</seealso>
        public virtual void PutRecordBatchAsync(PutRecordBatchRequest request, AmazonServiceCallback<PutRecordBatchRequest, PutRecordBatchResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = PutRecordBatchRequestMarshaller.Instance;
            var unmarshaller = PutRecordBatchResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutRecordBatchRequest,PutRecordBatchResponse> responseObject 
                            = new AmazonServiceResult<PutRecordBatchRequest,PutRecordBatchResponse>((PutRecordBatchRequest)req, (PutRecordBatchResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<PutRecordBatchRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  TagDeliveryStream

        /// <summary>
        /// Initiates the asynchronous execution of the TagDeliveryStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagDeliveryStream operation on AmazonKinesisFirehoseClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/TagDeliveryStream">REST API Reference for TagDeliveryStream Operation</seealso>
        public virtual void TagDeliveryStreamAsync(TagDeliveryStreamRequest request, AmazonServiceCallback<TagDeliveryStreamRequest, TagDeliveryStreamResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = TagDeliveryStreamRequestMarshaller.Instance;
            var unmarshaller = TagDeliveryStreamResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<TagDeliveryStreamRequest,TagDeliveryStreamResponse> responseObject 
                            = new AmazonServiceResult<TagDeliveryStreamRequest,TagDeliveryStreamResponse>((TagDeliveryStreamRequest)req, (TagDeliveryStreamResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<TagDeliveryStreamRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  UntagDeliveryStream

        /// <summary>
        /// Initiates the asynchronous execution of the UntagDeliveryStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagDeliveryStream operation on AmazonKinesisFirehoseClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/UntagDeliveryStream">REST API Reference for UntagDeliveryStream Operation</seealso>
        public virtual void UntagDeliveryStreamAsync(UntagDeliveryStreamRequest request, AmazonServiceCallback<UntagDeliveryStreamRequest, UntagDeliveryStreamResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = UntagDeliveryStreamRequestMarshaller.Instance;
            var unmarshaller = UntagDeliveryStreamResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UntagDeliveryStreamRequest,UntagDeliveryStreamResponse> responseObject 
                            = new AmazonServiceResult<UntagDeliveryStreamRequest,UntagDeliveryStreamResponse>((UntagDeliveryStreamRequest)req, (UntagDeliveryStreamResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<UntagDeliveryStreamRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateDestination

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDestination operation on AmazonKinesisFirehoseClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/firehose-2015-08-04/UpdateDestination">REST API Reference for UpdateDestination Operation</seealso>
        public virtual void UpdateDestinationAsync(UpdateDestinationRequest request, AmazonServiceCallback<UpdateDestinationRequest, UpdateDestinationResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var marshaller = UpdateDestinationRequestMarshaller.Instance;
            var unmarshaller = UpdateDestinationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateDestinationRequest,UpdateDestinationResponse> responseObject 
                            = new AmazonServiceResult<UpdateDestinationRequest,UpdateDestinationResponse>((UpdateDestinationRequest)req, (UpdateDestinationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke<UpdateDestinationRequest>(request, marshaller, unmarshaller, options, callbackHelper);
        }

        #endregion
        
    }
}