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
#pragma warning disable CS0612,CS0618
namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Recipes Marshaller
    /// </summary>
    public class RecipesMarshaller : IRequestMarshaller<Recipes, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Recipes requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetConfigure())
            {
                context.Writer.WritePropertyName("Configure");
                context.Writer.WriteStartArray();
                foreach(var requestObjectConfigureListValue in requestObject.Configure)
                {
                        context.Writer.WriteStringValue(requestObjectConfigureListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDeploy())
            {
                context.Writer.WritePropertyName("Deploy");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDeployListValue in requestObject.Deploy)
                {
                        context.Writer.WriteStringValue(requestObjectDeployListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSetup())
            {
                context.Writer.WritePropertyName("Setup");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSetupListValue in requestObject.Setup)
                {
                        context.Writer.WriteStringValue(requestObjectSetupListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetShutdown())
            {
                context.Writer.WritePropertyName("Shutdown");
                context.Writer.WriteStartArray();
                foreach(var requestObjectShutdownListValue in requestObject.Shutdown)
                {
                        context.Writer.WriteStringValue(requestObjectShutdownListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetUndeploy())
            {
                context.Writer.WritePropertyName("Undeploy");
                context.Writer.WriteStartArray();
                foreach(var requestObjectUndeployListValue in requestObject.Undeploy)
                {
                        context.Writer.WriteStringValue(requestObjectUndeployListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RecipesMarshaller Instance = new RecipesMarshaller();

    }
}