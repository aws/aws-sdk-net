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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kendra.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GroupMembers Marshaller
    /// </summary>
    public class GroupMembersMarshaller : IRequestMarshaller<GroupMembers, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(GroupMembers requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetMemberGroups())
            {
                context.Writer.WritePropertyName("MemberGroups");
                context.Writer.WriteStartArray();
                foreach(var requestObjectMemberGroupsListValue in requestObject.MemberGroups)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MemberGroupMarshaller.Instance;
                    marshaller.Marshall(requestObjectMemberGroupsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMemberUsers())
            {
                context.Writer.WritePropertyName("MemberUsers");
                context.Writer.WriteStartArray();
                foreach(var requestObjectMemberUsersListValue in requestObject.MemberUsers)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MemberUserMarshaller.Instance;
                    marshaller.Marshall(requestObjectMemberUsersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetS3PathforGroupMembers())
            {
                context.Writer.WritePropertyName("S3PathforGroupMembers");
                context.Writer.WriteStartObject();

                var marshaller = S3PathMarshaller.Instance;
                marshaller.Marshall(requestObject.S3PathforGroupMembers, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static GroupMembersMarshaller Instance = new GroupMembersMarshaller();

    }
}