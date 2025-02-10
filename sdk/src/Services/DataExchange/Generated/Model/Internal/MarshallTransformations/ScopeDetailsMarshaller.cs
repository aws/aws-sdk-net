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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataExchange.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DataExchange.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ScopeDetails Marshaller
    /// </summary>
    public class ScopeDetailsMarshaller : IRequestMarshaller<ScopeDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ScopeDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetLakeFormationTagPolicies())
            {
                context.Writer.WritePropertyName("LakeFormationTagPolicies");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLakeFormationTagPoliciesListValue in requestObject.LakeFormationTagPolicies)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = LakeFormationTagPolicyDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectLakeFormationTagPoliciesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRedshiftDataShares())
            {
                context.Writer.WritePropertyName("RedshiftDataShares");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRedshiftDataSharesListValue in requestObject.RedshiftDataShares)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = RedshiftDataShareDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectRedshiftDataSharesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetS3DataAccesses())
            {
                context.Writer.WritePropertyName("S3DataAccesses");
                context.Writer.WriteStartArray();
                foreach(var requestObjectS3DataAccessesListValue in requestObject.S3DataAccesses)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = S3DataAccessDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectS3DataAccessesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ScopeDetailsMarshaller Instance = new ScopeDetailsMarshaller();

    }
}