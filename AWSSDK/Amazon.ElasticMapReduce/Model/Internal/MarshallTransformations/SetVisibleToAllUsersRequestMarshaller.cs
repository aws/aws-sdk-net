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

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Set Visible To All Users Request Marshaller
    /// </summary>       
    public class SetVisibleToAllUsersRequestMarshaller : IMarshaller<IRequest, SetVisibleToAllUsersRequest>
    {
        public IRequest Marshall(SetVisibleToAllUsersRequest setVisibleToAllUsersRequest)
        {
            IRequest request = new DefaultRequest(setVisibleToAllUsersRequest, "AmazonElasticMapReduce");
            request.Parameters.Add("Action", "SetVisibleToAllUsers");
            request.Parameters.Add("Version", "2009-03-31");
            if (setVisibleToAllUsersRequest != null)
            {
                List<string> jobFlowIdsList = setVisibleToAllUsersRequest.JobFlowIds;

                int jobFlowIdsListIndex = 1;
                foreach (string jobFlowIdsListValue in jobFlowIdsList)
                { 
                    request.Parameters.Add("JobFlowIds.member." + jobFlowIdsListIndex, StringUtils.FromString(jobFlowIdsListValue));
                    jobFlowIdsListIndex++;
                }
            }
            if (setVisibleToAllUsersRequest != null && setVisibleToAllUsersRequest.IsSetVisibleToAllUsers())
            {
                request.Parameters.Add("VisibleToAllUsers", StringUtils.FromBool(setVisibleToAllUsersRequest.VisibleToAllUsers));
            }

            return request;
        }
    }
}
