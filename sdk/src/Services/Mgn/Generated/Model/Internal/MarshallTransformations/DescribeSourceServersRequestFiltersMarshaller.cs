/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Mgn.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Mgn.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeSourceServersRequestFilters Marshaller
    /// </summary>
    public class DescribeSourceServersRequestFiltersMarshaller : IRequestMarshaller<DescribeSourceServersRequestFilters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DescribeSourceServersRequestFilters requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetApplicationIDs())
            {
                context.Writer.WritePropertyName("applicationIDs");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectApplicationIDsListValue in requestObject.ApplicationIDs)
                {
                        context.Writer.Write(requestObjectApplicationIDsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetIsArchived())
            {
                context.Writer.WritePropertyName("isArchived");
                context.Writer.Write(requestObject.IsArchived);
            }

            if(requestObject.IsSetLifeCycleStates())
            {
                context.Writer.WritePropertyName("lifeCycleStates");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectLifeCycleStatesListValue in requestObject.LifeCycleStates)
                {
                        context.Writer.Write(requestObjectLifeCycleStatesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetReplicationTypes())
            {
                context.Writer.WritePropertyName("replicationTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectReplicationTypesListValue in requestObject.ReplicationTypes)
                {
                        context.Writer.Write(requestObjectReplicationTypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSourceServerIDs())
            {
                context.Writer.WritePropertyName("sourceServerIDs");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSourceServerIDsListValue in requestObject.SourceServerIDs)
                {
                        context.Writer.Write(requestObjectSourceServerIDsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DescribeSourceServersRequestFiltersMarshaller Instance = new DescribeSourceServersRequestFiltersMarshaller();

    }
}