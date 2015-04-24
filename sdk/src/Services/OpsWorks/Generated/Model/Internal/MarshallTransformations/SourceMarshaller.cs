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

/*
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpsWorks.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Source Marshaller
    /// </summary>       
    public class SourceMarshaller : IRequestMarshaller<Source, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Source requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetPassword())
            {
                context.Writer.WritePropertyName("Password");
                context.Writer.Write(requestObject.Password);
            }

            if(requestObject.IsSetRevision())
            {
                context.Writer.WritePropertyName("Revision");
                context.Writer.Write(requestObject.Revision);
            }

            if(requestObject.IsSetSshKey())
            {
                context.Writer.WritePropertyName("SshKey");
                context.Writer.Write(requestObject.SshKey);
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.Write(requestObject.Type);
            }

            if(requestObject.IsSetUrl())
            {
                context.Writer.WritePropertyName("Url");
                context.Writer.Write(requestObject.Url);
            }

            if(requestObject.IsSetUsername())
            {
                context.Writer.WritePropertyName("Username");
                context.Writer.Write(requestObject.Username);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static SourceMarshaller Instance = new SourceMarshaller();

    }
}