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

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Create Tags Request Marshaller
    /// </summary>       
    public class CreateTagsRequestMarshaller : IMarshaller<IRequest, CreateTagsRequest>
    {
        public IRequest Marshall(CreateTagsRequest createTagsRequest)
        {
            IRequest request = new DefaultRequest(createTagsRequest, "AmazonEC2");
            request.Parameters.Add("Action", "CreateTags");
            request.Parameters.Add("Version", "2013-10-15");
            if (createTagsRequest != null)
            {
                List<string> resourcesList = createTagsRequest.Resources;

                int resourcesListIndex = 1;
                foreach (string resourcesListValue in resourcesList)
                { 
                    request.Parameters.Add("ResourceId." + resourcesListIndex, StringUtils.FromString(resourcesListValue));
                    resourcesListIndex++;
                }
            }

            if (createTagsRequest != null)
            {
                List<Tag> tagsList = createTagsRequest.Tags;
                int tagsListIndex = 1;
                foreach (Tag tagsListValue in tagsList)
                {
                    if (tagsListValue != null && tagsListValue.IsSetKey())
                    {
                        request.Parameters.Add("Tag." + tagsListIndex + ".Key", StringUtils.FromString(tagsListValue.Key));
                    }
                    if (tagsListValue != null && tagsListValue.IsSetValue())
                    {
                        request.Parameters.Add("Tag." + tagsListIndex + ".Value", StringUtils.FromString(tagsListValue.Value));
                    }

                    tagsListIndex++;
                }
            }

            return request;
        }
    }
}
