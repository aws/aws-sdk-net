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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MachineLearning.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MachineLearning.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RedshiftDatabaseCredentials Marshaller
    /// </summary>       
    public class RedshiftDatabaseCredentialsMarshaller : IRequestMarshaller<RedshiftDatabaseCredentials, JsonMarshallerContext> 
    {
        public void Marshall(RedshiftDatabaseCredentials requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetPassword())
            {
                context.Writer.WritePropertyName("Password");
                context.Writer.Write(requestObject.Password);
            }

            if(requestObject.IsSetUsername())
            {
                context.Writer.WritePropertyName("Username");
                context.Writer.Write(requestObject.Username);
            }

        }

        public readonly static RedshiftDatabaseCredentialsMarshaller Instance = new RedshiftDatabaseCredentialsMarshaller();

    }
}