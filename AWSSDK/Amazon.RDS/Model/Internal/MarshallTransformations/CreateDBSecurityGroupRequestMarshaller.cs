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
    /// Create D B Security Group Request Marshaller
    /// </summary>       
    public class CreateDBSecurityGroupRequestMarshaller : IMarshaller<IRequest, CreateDBSecurityGroupRequest>
    {
        public IRequest Marshall(CreateDBSecurityGroupRequest createDBSecurityGroupRequest)
        {
            IRequest request = new DefaultRequest(createDBSecurityGroupRequest, "AmazonRDS");
            request.Parameters.Add("Action", "CreateDBSecurityGroup");
            request.Parameters.Add("Version", "2013-09-09");
            if (createDBSecurityGroupRequest != null && createDBSecurityGroupRequest.IsSetDBSecurityGroupName())
            {
                request.Parameters.Add("DBSecurityGroupName", StringUtils.FromString(createDBSecurityGroupRequest.DBSecurityGroupName));
            }
            if (createDBSecurityGroupRequest != null && createDBSecurityGroupRequest.IsSetDBSecurityGroupDescription())
            {
                request.Parameters.Add("DBSecurityGroupDescription", StringUtils.FromString(createDBSecurityGroupRequest.DBSecurityGroupDescription));
            }

            if (createDBSecurityGroupRequest != null)
            {
                List<Tag> tagsList = createDBSecurityGroupRequest.Tags;
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
