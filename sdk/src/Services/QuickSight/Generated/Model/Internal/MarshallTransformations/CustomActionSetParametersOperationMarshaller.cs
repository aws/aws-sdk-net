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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CustomActionSetParametersOperation Marshaller
    /// </summary>
    public class CustomActionSetParametersOperationMarshaller : IRequestMarshaller<CustomActionSetParametersOperation, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CustomActionSetParametersOperation requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetParameterValueConfigurations())
            {
                context.Writer.WritePropertyName("ParameterValueConfigurations");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectParameterValueConfigurationsListValue in requestObject.ParameterValueConfigurations)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = SetParameterValueConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectParameterValueConfigurationsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CustomActionSetParametersOperationMarshaller Instance = new CustomActionSetParametersOperationMarshaller();

    }
}