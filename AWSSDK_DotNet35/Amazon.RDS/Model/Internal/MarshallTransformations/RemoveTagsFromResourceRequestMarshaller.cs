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
    /// Remove Tags From Resource Request Marshaller
    /// </summary>       
    public class RemoveTagsFromResourceRequestMarshaller : IMarshaller<IRequest, RemoveTagsFromResourceRequest>
    {
        public IRequest Marshall(RemoveTagsFromResourceRequest removeTagsFromResourceRequest)
        {
            IRequest request = new DefaultRequest(removeTagsFromResourceRequest, "AmazonRDS");
            request.Parameters.Add("Action", "RemoveTagsFromResource");
            request.Parameters.Add("Version", "2013-09-09");
            if (removeTagsFromResourceRequest != null && removeTagsFromResourceRequest.IsSetResourceName())
            {
                request.Parameters.Add("ResourceName", StringUtils.FromString(removeTagsFromResourceRequest.ResourceName));
            }
            if (removeTagsFromResourceRequest != null)
            {
                List<string> tagKeysList = removeTagsFromResourceRequest.TagKeys;

                int tagKeysListIndex = 1;
                foreach (string tagKeysListValue in tagKeysList)
                { 
                    request.Parameters.Add("TagKeys.member." + tagKeysListIndex, StringUtils.FromString(tagKeysListValue));
                    tagKeysListIndex++;
                }
            }

            return request;
        }
    }
}
