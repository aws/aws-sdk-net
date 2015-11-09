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

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.S3.Util;
using Amazon.Util;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace Amazon.S3
{
    public partial class AmazonS3Client
    {

        #region Post Object

        /// <summary>
        /// Upload data to Amazon S3 using HTTP POST.
        /// </summary>
        /// <remarks>
        /// For more information, <see href="http://docs.aws.amazon.com/AmazonS3/latest/dev/UsingHTTPPOST.html"/>
        /// </remarks>
        /// <param name="request">Request object which describes the data to POST</param>
        public void PostObjectAsync(PostObjectRequest request, AmazonServiceCallback<PostObjectRequest, PostObjectResponse> callback,AsyncOptions options = null)
        {
	        options = options == null ? new AsyncOptions() : options;
           

            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper
                = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) =>
                {
                    AmazonServiceResult<PostObjectRequest, PostObjectResponse> responseObject
                        = new AmazonServiceResult<PostObjectRequest, PostObjectResponse>((PostObjectRequest)req,(PostObjectResponse)res,ex,ao.State);
                    if(callback !=null)
						callback(responseObject);
                };
            ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
            {
                // Provide a default policy if user doesn't set it.
                if (request.SignedPolicy == null)
                {
                    CreateSignedPolicy(request);
                }
                PostObject(request, options, callbackHelper);
            }));
            
        }

        private void CreateSignedPolicy(PostObjectRequest request)
        {
            if (request.ContentType == null)
            {
                int pos = request.Key.LastIndexOf('.');
                string ext = null;
                if (pos != -1)
                {
                    ext = request.Key.Substring(pos, request.Key.Length - pos);
                    request.ContentType = AmazonS3Util.MimeTypeFromExtension(ext);
                }
                else
                {
                    request.ContentType = "application/octet-stream";
                }
            }

            string policyString = null;
            int position = request.Key.LastIndexOf('/');
            if (position == -1)
            {
                policyString = "{\"expiration\": \"" + DateTime.UtcNow.AddHours(24).ToString("yyyy-MM-ddTHH:mm:ssZ") + "\",\"conditions\": [{\"bucket\": \"" +
                    request.Bucket + "\"},[\"starts-with\", \"$key\", \"" + "\"],{\"acl\": \"private\"},[\"eq\", \"$Content-Type\", " + "\"" + request.ContentType + "\"" + "]]}";
            }
            else
            {
                policyString = "{\"expiration\": \"" + DateTime.UtcNow.AddHours(24).ToString("yyyy-MM-ddTHH:mm:ssZ") + "\",\"conditions\": [{\"bucket\": \"" +
                    request.Bucket + "\"},[\"starts-with\", \"$key\", \"" + request.Key.Substring(0, position) + "/\"],{\"acl\": \"private\"},[\"eq\", \"$Content-Type\", " + "\"" + request.ContentType + "\"" + "]]}";
            }
            request.SignedPolicy = S3PostUploadSignedPolicy.GetSignedPolicy(policyString, base.Credentials);
        }

        private void PostObject(PostObjectRequest request, AsyncOptions options, Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper)
        {
            string url;
            string subdomain = request.Region.Equals(RegionEndpoint.USEast1) ? "s3" : "s3-" + request.Region.SystemName;
            IDictionary<string, string> headers = new Dictionary<string, string>();

            if (request.Bucket.IndexOf('.') > -1)
                url = string.Format(CultureInfo.InvariantCulture, "https://{0}.amazonaws.com/{1}/", subdomain, request.Bucket);
            else
                url = string.Format(CultureInfo.InvariantCulture, "https://{0}.{1}.amazonaws.com", request.Bucket, subdomain);
            Uri uri = new Uri(url);

            UnityWebRequest webRequest = new UnityWebRequest(uri);

            var boundary = Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Replace('=', 'z');

            headers[HeaderKeys.ContentTypeHeader] = string.Format(CultureInfo.InvariantCulture, "multipart/form-data; boundary={0}", boundary);
            headers[HeaderKeys.UserAgentHeader] = AWSSDKUtils.UserAgentHeader;

            webRequest.Method = "POST";

            using (var reqStream = new MemoryStream())
            {
                request.WriteFormData(boundary, reqStream);

                byte[] boundaryBytes = Encoding.UTF8.GetBytes(string.Format(CultureInfo.InvariantCulture, "--{0}\r\nContent-Disposition: form-data; name=\"file\"\r\n\r\n", boundary));

                reqStream.Write(boundaryBytes, 0, boundaryBytes.Length);

                using (var inputStream = null == request.Path ? request.InputStream : File.OpenRead(request.Path))
                {
                    byte[] buf = new byte[1024];
                    int bytesRead;
                    while ((bytesRead = inputStream.Read(buf, 0, 1024)) > 0)
                    {
                        reqStream.Write(buf, 0, bytesRead);
                    }
                }

                byte[] endBoundaryBytes = Encoding.UTF8.GetBytes(string.Format(CultureInfo.InvariantCulture, "\r\n--{0}--", boundary));

                reqStream.Write(endBoundaryBytes, 0, endBoundaryBytes.Length);

                webRequest.WriteToRequestBody(null, reqStream.ToArray(), headers);
            }

            var executionContext = new AsyncExecutionContext(
                new AsyncRequestContext(this.Config.LogMetrics)
                {
                    ClientConfig = this.Config,
                    OriginalRequest = request,
                    Action = callbackHelper,
                    AsyncOptions = options,
                    IsAsync = true
                },
                new AsyncResponseContext()
            );

            webRequest.SetRequestHeaders(headers);
            executionContext.RuntimeState = webRequest;


            executionContext.ResponseContext.AsyncResult =
                       new RuntimeAsyncResult(executionContext.RequestContext.Callback,
                           executionContext.RequestContext.State);
            executionContext.ResponseContext.AsyncResult.AsyncOptions = executionContext.RequestContext.AsyncOptions;
            executionContext.ResponseContext.AsyncResult.Action = executionContext.RequestContext.Action;
            executionContext.ResponseContext.AsyncResult.Request = executionContext.RequestContext.OriginalRequest;

            webRequest.BeginGetResponse(new AsyncCallback(ProcessPostResponse), executionContext);
        }

        private void ProcessPostResponse(IAsyncResult result)
        {
            IAsyncExecutionContext executionContext = null;
            UnityWebRequest httpRequest = null;
            bool isException = false;
            try
            {
                executionContext = result.AsyncState as IAsyncExecutionContext;
                httpRequest = executionContext.RuntimeState as UnityWebRequest;

                var httpResponse = httpRequest.EndGetResponse(result);
                executionContext.ResponseContext.HttpResponse = httpResponse;
            }
            catch (Exception exception)
            {
                // Capture the exception and invoke outer handlers to 
                // process the exception.
                executionContext.ResponseContext.AsyncResult.Exception = exception;
                isException = true;
            }
            finally
            {
                httpRequest.Dispose();
            }

            PostResponseHelper(result, isException);
        }

        private void PostResponseHelper(IAsyncResult result,bool isException)
        {
            IAsyncExecutionContext executionContext = result.AsyncState as IAsyncExecutionContext;
            IWebResponseData response = isException ? ((HttpErrorResponseException)executionContext.ResponseContext.AsyncResult.Exception).Response : executionContext.ResponseContext.HttpResponse;
            PostObjectResponse postResponse = new PostObjectResponse();
            postResponse.HttpStatusCode = response.StatusCode;
            postResponse.ContentLength = response.ContentLength;

            if (response.IsHeaderPresent(HeaderKeys.XAmzRequestIdHeader))
                postResponse.RequestId = response.GetHeaderValue(HeaderKeys.XAmzRequestIdHeader);
            if (response.IsHeaderPresent(HeaderKeys.XAmzId2Header))
                postResponse.HostId = response.GetHeaderValue(HeaderKeys.XAmzId2Header);

            PostObjectRequest request = executionContext.RequestContext.OriginalRequest as PostObjectRequest;

            RuntimeAsyncResult asyncResult = executionContext.ResponseContext.AsyncResult as RuntimeAsyncResult;
            asyncResult.Request = request;
            asyncResult.Response = postResponse;
            asyncResult.Exception = executionContext.ResponseContext.AsyncResult.Exception;
            asyncResult.Action = executionContext.RequestContext.Action;
            asyncResult.InvokeCallback();
        }


        #endregion
    }
}
