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
using Amazon.Util.Internal;
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
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public void PostObjectAsync(PostObjectRequest request, AmazonServiceCallback<PostObjectRequest, PostObjectResponse> callback, AsyncOptions options = null)
        {
            options = options == null ? new AsyncOptions() : options;

            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper
                = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) =>
                {
                    AmazonServiceResult<PostObjectRequest, PostObjectResponse> responseObject
                        = new AmazonServiceResult<PostObjectRequest, PostObjectResponse>((PostObjectRequest)req, (PostObjectResponse)res, ex, ao.State);
                    if (callback != null)
                        callback(responseObject);
                };

            ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
            {
                // Provide a default policy if user doesn't set it.
                try
                {
                    InferContentType(request);
                    if (request.SignedPolicy == null)
                    {
                        CreateSignedPolicy(request);
                    }
                    PostObject(request, options, callbackHelper);
                }
                catch (Exception e)
                {
                    callback(new AmazonServiceResult<PostObjectRequest, PostObjectResponse>(request, null, e, options.State));
                }
            }));

        }

        private void InferContentType(PostObjectRequest request)
        {
            if (String.IsNullOrEmpty(request.Headers.ContentType))
            {
                if (request.Key.IndexOf('.') > -1)
                    request.Headers.ContentType = AmazonS3Util.MimeTypeFromExtension(request.Key.Substring(request.Key.LastIndexOf('.')));
                else if (!String.IsNullOrEmpty(request.Path) && request.Path.IndexOf('.') > -1)
                    request.Headers.ContentType = AmazonS3Util.MimeTypeFromExtension(request.Key.Substring(request.Path.LastIndexOf('.')));
                else
                    request.Headers.ContentType = "application/octet-stream";
            }
        }

        private void CreateSignedPolicy(PostObjectRequest request)
        {
            StringBuilder metadataPolicy = new StringBuilder();
            foreach (var kvp in request.Metadata)
            {
                var metakey = kvp.Key.StartsWith(S3Constants.PostFormDataXAmzPrefix, StringComparison.Ordinal) ? kvp.Key : S3Constants.PostFormDataMetaPrefix + kvp.Key;
                metadataPolicy.Append(string.Format(",{{\"{0}\": \"{1}\"}}", metakey, kvp.Value));
            }

            StringBuilder headersPolicy = new StringBuilder();
            foreach (var key in request.Headers.Keys)
            {
                headersPolicy.Append(string.Format(",{{\"{0}\": \"{1}\"}}", key, request.Headers[key]));
            }

            string policyString = null;
            int position = request.Key.LastIndexOf('/');
            if (position == -1)
            {
                policyString = "{\"expiration\": \"" + DateTime.UtcNow.AddHours(24).ToString("yyyy-MM-ddTHH:mm:ssZ") + "\",\"conditions\": [{\"bucket\": \"" +
                    request.Bucket + "\"},[\"starts-with\", \"$key\", \"" + "\"],{\"acl\": \"" + request.CannedACL.Value + "\"},[\"eq\", \"$Content-Type\", " +
                    "\"" + request.Headers.ContentType + "\"" + "]" + metadataPolicy.ToString() + headersPolicy.ToString() + "]}";
            }
            else
            {
                policyString = "{\"expiration\": \"" + DateTime.UtcNow.AddHours(24).ToString("yyyy-MM-ddTHH:mm:ssZ") + "\",\"conditions\": [{\"bucket\": \"" +
                    request.Bucket + "\"},[\"starts-with\", \"$key\", \"" + request.Key.Substring(0, position) + "/\"],{\"acl\": \"" + request.CannedACL.Value +
                    "\"},[\"eq\", \"$Content-Type\", " + "\"" + request.Headers.ContentType + "\"" + "]" + metadataPolicy.ToString() + headersPolicy.ToString() + "]}";
            }
            if (Config.SignatureVersion == "2")
            {
                request.SignedPolicy = S3PostUploadSignedPolicy.GetSignedPolicy(policyString, base.Credentials);
            }
            else
            {
                request.SignedPolicy = S3PostUploadSignedPolicy.GetSignedPolicyV4(policyString, base.Credentials, request.Region);
            }
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

            IHttpRequest<string> webRequest = null;
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
                webRequest = new UnityWwwRequest(uri);
            else
                webRequest = new UnityRequest(uri);

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

                var callback = ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)request).StreamUploadProgressCallback;
                if (callback != null)
                    webRequest.SetupProgressListeners(reqStream, 0, request, callback);
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
            IHttpRequest<string> httpRequest = null;
            try
            {
                executionContext = result.AsyncState as IAsyncExecutionContext;
                httpRequest = executionContext.RuntimeState as IHttpRequest<string>;

                var httpResponse = httpRequest.EndGetResponse(result);
                executionContext.ResponseContext.HttpResponse = httpResponse;
            }
            catch (Exception exception)
            {
                // Capture the exception and invoke outer handlers to 
                // process the exception.
                executionContext.ResponseContext.AsyncResult.Exception = exception;
            }
            finally
            {
                httpRequest.Dispose();
            }

            PostResponseHelper(result);
        }

        private void PostResponseHelper(IAsyncResult result)
        {
            IAsyncExecutionContext executionContext = result.AsyncState as IAsyncExecutionContext;
            IWebResponseData response = executionContext.ResponseContext.HttpResponse;
            RuntimeAsyncResult asyncResult = executionContext.ResponseContext.AsyncResult as RuntimeAsyncResult;

            if (executionContext.ResponseContext.AsyncResult.Exception == null)
            {
                PostObjectResponse postResponse = new PostObjectResponse();
                postResponse.HttpStatusCode = response.StatusCode;
                postResponse.ContentLength = response.ContentLength;

                if (response.IsHeaderPresent(HeaderKeys.XAmzRequestIdHeader))
                    postResponse.RequestId = response.GetHeaderValue(HeaderKeys.XAmzRequestIdHeader);
                if (response.IsHeaderPresent(HeaderKeys.XAmzId2Header))
                    postResponse.HostId = response.GetHeaderValue(HeaderKeys.XAmzId2Header);
                if (response.IsHeaderPresent(HeaderKeys.XAmzVersionIdHeader))
                    postResponse.VersionId = response.GetHeaderValue(HeaderKeys.XAmzVersionIdHeader);

                PostObjectRequest request = executionContext.RequestContext.OriginalRequest as PostObjectRequest;
                asyncResult.Request = request;
                asyncResult.Response = postResponse;
            }

            asyncResult.Exception = executionContext.ResponseContext.AsyncResult.Exception;
            asyncResult.Action = executionContext.RequestContext.Action;
            asyncResult.InvokeCallback();
        }


        #endregion
    }
}
