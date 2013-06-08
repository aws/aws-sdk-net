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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Add Tags To Resource Request Marshaller
    /// </summary>       
    public class AddTagsToResourceRequestMarshaller : IMarshaller<IRequest, AddTagsToResourceRequest>
    {
        public IRequest Marshall(AddTagsToResourceRequest addTagsToResourceRequest)
        {
            IRequest request = new DefaultRequest(addTagsToResourceRequest, "AmazonRDS");
            request.Parameters.Add("Action", "AddTagsToResource");
            request.Parameters.Add("Version", "2013-05-15");
            if (addTagsToResourceRequest != null && addTagsToResourceRequest.IsSetResourceName())
            {
                request.Parameters.Add("ResourceName", StringUtils.FromString(addTagsToResourceRequest.ResourceName));
            }

            if (addTagsToResourceRequest != null)
            {
                List<Tag> tagsList = addTagsToResourceRequest.Tags;
                int tagsListIndex = 1;
                foreach (Tag tagsListValue in tagsList)
                {
                    if (tagsListValue != null && tagsListValue.IsSetKey())
                    {
                        request.Parameters.Add("Tags.member." + tagsListIndex + ".Key", StringUtils.FromString(tagsListValue.Key));
                    }
                    if (tagsListValue != null && tagsListValue.IsSetValue())
                    {
                        request.Parameters.Add("Tags.member." + tagsListIndex + ".Value", StringUtils.FromString(tagsListValue.Value));
                    }

                    tagsListIndex++;
                }
            }

            return request;
        }
    }
}
