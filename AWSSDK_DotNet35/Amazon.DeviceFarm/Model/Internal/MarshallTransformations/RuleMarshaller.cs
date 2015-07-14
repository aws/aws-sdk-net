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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DeviceFarm.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DeviceFarm.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Rule Marshaller
    /// </summary>       
    public class RuleMarshaller : IRequestMarshaller<Rule, JsonMarshallerContext> 
    {
        public void Marshall(Rule requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAttribute())
            {
                context.Writer.WritePropertyName("attribute");
                context.Writer.Write(requestObject.Attribute);
            }

            if(requestObject.IsSetOperator())
            {
                context.Writer.WritePropertyName("operator");
                context.Writer.Write(requestObject.Operator);
            }

            if(requestObject.IsSetValue())
            {
                context.Writer.WritePropertyName("value");
                context.Writer.Write(requestObject.Value);
            }

        }

        public readonly static RuleMarshaller Instance = new RuleMarshaller();

    }
}