/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.S3.Util;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using System.Globalization;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Get Object Torrent Request Marshaller
    /// </summary>       
    public class GetObjectTorrentRequestMarshaller : IMarshaller<IRequest, GetObjectTorrentRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
		public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
		{
			return this.Marshall((GetObjectTorrentRequest)input);
		}

        public IRequest Marshall(GetObjectTorrentRequest getObjectTorrentRequest)
        {
            if (string.IsNullOrEmpty(getObjectTorrentRequest.Key))
                throw new System.ArgumentException("Key is a required property and must be set before making this call.", "GetObjectTorrentRequest.Key");

            IRequest request = new DefaultRequest(getObjectTorrentRequest, "AmazonS3");

            request.HttpMethod = "GET";

            if (getObjectTorrentRequest.IsSetRequestPayer())
                request.Headers.Add(S3Constants.AmzHeaderRequestPayer, S3Transforms.ToStringValue(getObjectTorrentRequest.RequestPayer.ToString()));
            if (getObjectTorrentRequest.IsSetRequestPayer())
                request.Headers.Add(S3Constants.AmzHeaderRequestPayer, S3Transforms.ToStringValue(getObjectTorrentRequest.RequestPayer.ToString()));

            request.ResourcePath = string.Format(CultureInfo.InvariantCulture, "/{0}/{1}",
                                                 S3Transforms.ToStringValue(getObjectTorrentRequest.BucketName),
                                                 S3Transforms.ToStringValue(getObjectTorrentRequest.Key));

            request.AddSubResource("torrent");
            request.UseQueryString = true;
            
            return request;
        }

	    private static GetObjectTorrentRequestMarshaller _instance;

	    public static GetObjectTorrentRequestMarshaller Instance
	    {
	        get
	        {
	            if (_instance == null)
	            {
	                _instance = new GetObjectTorrentRequestMarshaller();
	            }
	            return _instance;
	        }
	    }
    }
}
    
