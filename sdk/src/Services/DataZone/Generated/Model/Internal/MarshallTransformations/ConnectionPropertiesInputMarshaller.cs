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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ConnectionPropertiesInput Marshaller
    /// </summary>
    public class ConnectionPropertiesInputMarshaller : IRequestMarshaller<ConnectionPropertiesInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ConnectionPropertiesInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAmazonQProperties())
            {
                context.Writer.WritePropertyName("amazonQProperties");
                context.Writer.WriteObjectStart();

                var marshaller = AmazonQPropertiesInputMarshaller.Instance;
                marshaller.Marshall(requestObject.AmazonQProperties, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAthenaProperties())
            {
                context.Writer.WritePropertyName("athenaProperties");
                context.Writer.WriteObjectStart();

                var marshaller = AthenaPropertiesInputMarshaller.Instance;
                marshaller.Marshall(requestObject.AthenaProperties, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetGlueProperties())
            {
                context.Writer.WritePropertyName("glueProperties");
                context.Writer.WriteObjectStart();

                var marshaller = GluePropertiesInputMarshaller.Instance;
                marshaller.Marshall(requestObject.GlueProperties, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetHyperPodProperties())
            {
                context.Writer.WritePropertyName("hyperPodProperties");
                context.Writer.WriteObjectStart();

                var marshaller = HyperPodPropertiesInputMarshaller.Instance;
                marshaller.Marshall(requestObject.HyperPodProperties, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetIamProperties())
            {
                context.Writer.WritePropertyName("iamProperties");
                context.Writer.WriteObjectStart();

                var marshaller = IamPropertiesInputMarshaller.Instance;
                marshaller.Marshall(requestObject.IamProperties, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMlflowProperties())
            {
                context.Writer.WritePropertyName("mlflowProperties");
                context.Writer.WriteObjectStart();

                var marshaller = MlflowPropertiesInputMarshaller.Instance;
                marshaller.Marshall(requestObject.MlflowProperties, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRedshiftProperties())
            {
                context.Writer.WritePropertyName("redshiftProperties");
                context.Writer.WriteObjectStart();

                var marshaller = RedshiftPropertiesInputMarshaller.Instance;
                marshaller.Marshall(requestObject.RedshiftProperties, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetS3Properties())
            {
                context.Writer.WritePropertyName("s3Properties");
                context.Writer.WriteObjectStart();

                var marshaller = S3PropertiesInputMarshaller.Instance;
                marshaller.Marshall(requestObject.S3Properties, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSparkEmrProperties())
            {
                context.Writer.WritePropertyName("sparkEmrProperties");
                context.Writer.WriteObjectStart();

                var marshaller = SparkEmrPropertiesInputMarshaller.Instance;
                marshaller.Marshall(requestObject.SparkEmrProperties, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSparkGlueProperties())
            {
                context.Writer.WritePropertyName("sparkGlueProperties");
                context.Writer.WriteObjectStart();

                var marshaller = SparkGluePropertiesInputMarshaller.Instance;
                marshaller.Marshall(requestObject.SparkGlueProperties, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ConnectionPropertiesInputMarshaller Instance = new ConnectionPropertiesInputMarshaller();

    }
}