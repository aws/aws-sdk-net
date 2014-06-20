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
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticTranscoder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeletePreset Request Marshaller
    /// </summary>       
    public class DeletePresetRequestMarshaller : IMarshaller<IRequest, DeletePresetRequest> 
    {
        public IRequest Marshall(DeletePresetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticTranscoder");
            string target = ".DeletePreset";
            request.Headers["X-Amz-Target"] = target;

            request.HttpMethod = "DELETE";

            string uriResourcePath = "/2012-09-25/presets/{Id}";
            uriResourcePath = uriResourcePath.Replace("{Id}", publicRequest.Id ?? string.Empty);
            request.ResourcePath = uriResourcePath;
            request.UseQueryString = true;
            return request;
        }


    }
}