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

using Amazon.AutoScaling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.AutoScaling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Delete Tags Request Marshaller
    /// </summary>       
    public class DeleteTagsRequestMarshaller : IMarshaller<IRequest, DeleteTagsRequest>
    {
        public IRequest Marshall(DeleteTagsRequest deleteTagsRequest)
        {
            IRequest request = new DefaultRequest(deleteTagsRequest, "AmazonAutoScaling");
            request.Parameters.Add("Action", "DeleteTags");
            request.Parameters.Add("Version", "2011-01-01");

            if (deleteTagsRequest != null)
            {
                List<Tag> tagsList = deleteTagsRequest.Tags;
                int tagsListIndex = 1;
                foreach (Tag tagsListValue in tagsList)
                {
                    if (tagsListValue != null && tagsListValue.IsSetResourceId())
                    {
                        request.Parameters.Add("Tags.member." + tagsListIndex + ".ResourceId", StringUtils.FromString(tagsListValue.ResourceId));
                    }
                    if (tagsListValue != null && tagsListValue.IsSetResourceType())
                    {
                        request.Parameters.Add("Tags.member." + tagsListIndex + ".ResourceType", StringUtils.FromString(tagsListValue.ResourceType));
                    }
                    if (tagsListValue != null && tagsListValue.IsSetKey())
                    {
                        request.Parameters.Add("Tags.member." + tagsListIndex + ".Key", StringUtils.FromString(tagsListValue.Key));
                    }
                    if (tagsListValue != null && tagsListValue.IsSetValue())
                    {
                        request.Parameters.Add("Tags.member." + tagsListIndex + ".Value", StringUtils.FromString(tagsListValue.Value));
                    }
                    if (tagsListValue != null && tagsListValue.IsSetPropagateAtLaunch())
                    {
                        request.Parameters.Add("Tags.member." + tagsListIndex + ".PropagateAtLaunch", StringUtils.FromBool(tagsListValue.PropagateAtLaunch));
                    }

                    tagsListIndex++;
                }
            }

            return request;
        }
    }
}
