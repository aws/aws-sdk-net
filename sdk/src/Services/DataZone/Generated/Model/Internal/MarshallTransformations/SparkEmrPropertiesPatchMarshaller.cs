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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataZone.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SparkEmrPropertiesPatch Marshaller
    /// </summary>
    public class SparkEmrPropertiesPatchMarshaller : IRequestMarshaller<SparkEmrPropertiesPatch, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SparkEmrPropertiesPatch requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetComputeArn())
            {
                context.Writer.WritePropertyName("computeArn");
                context.Writer.WriteStringValue(requestObject.ComputeArn);
            }

            if(requestObject.IsSetInstanceProfileArn())
            {
                context.Writer.WritePropertyName("instanceProfileArn");
                context.Writer.WriteStringValue(requestObject.InstanceProfileArn);
            }

            if(requestObject.IsSetJavaVirtualEnv())
            {
                context.Writer.WritePropertyName("javaVirtualEnv");
                context.Writer.WriteStringValue(requestObject.JavaVirtualEnv);
            }

            if(requestObject.IsSetLogUri())
            {
                context.Writer.WritePropertyName("logUri");
                context.Writer.WriteStringValue(requestObject.LogUri);
            }

            if(requestObject.IsSetManagedEndpointArn())
            {
                context.Writer.WritePropertyName("managedEndpointArn");
                context.Writer.WriteStringValue(requestObject.ManagedEndpointArn);
            }

            if(requestObject.IsSetPythonVirtualEnv())
            {
                context.Writer.WritePropertyName("pythonVirtualEnv");
                context.Writer.WriteStringValue(requestObject.PythonVirtualEnv);
            }

            if(requestObject.IsSetRuntimeRole())
            {
                context.Writer.WritePropertyName("runtimeRole");
                context.Writer.WriteStringValue(requestObject.RuntimeRole);
            }

            if(requestObject.IsSetTrustedCertificatesS3Uri())
            {
                context.Writer.WritePropertyName("trustedCertificatesS3Uri");
                context.Writer.WriteStringValue(requestObject.TrustedCertificatesS3Uri);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SparkEmrPropertiesPatchMarshaller Instance = new SparkEmrPropertiesPatchMarshaller();

    }
}