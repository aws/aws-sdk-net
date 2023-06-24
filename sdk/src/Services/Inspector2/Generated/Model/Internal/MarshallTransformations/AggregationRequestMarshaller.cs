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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Inspector2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Inspector2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AggregationRequest Marshaller
    /// </summary>
    public class AggregationRequestMarshaller : IRequestMarshaller<AggregationRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AggregationRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAccountAggregation())
            {
                context.Writer.WritePropertyName("accountAggregation");
                context.Writer.WriteObjectStart();

                var marshaller = AccountAggregationMarshaller.Instance;
                marshaller.Marshall(requestObject.AccountAggregation, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAmiAggregation())
            {
                context.Writer.WritePropertyName("amiAggregation");
                context.Writer.WriteObjectStart();

                var marshaller = AmiAggregationMarshaller.Instance;
                marshaller.Marshall(requestObject.AmiAggregation, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsEcrContainerAggregation())
            {
                context.Writer.WritePropertyName("awsEcrContainerAggregation");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEcrContainerAggregationMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEcrContainerAggregation, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEc2InstanceAggregation())
            {
                context.Writer.WritePropertyName("ec2InstanceAggregation");
                context.Writer.WriteObjectStart();

                var marshaller = Ec2InstanceAggregationMarshaller.Instance;
                marshaller.Marshall(requestObject.Ec2InstanceAggregation, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFindingTypeAggregation())
            {
                context.Writer.WritePropertyName("findingTypeAggregation");
                context.Writer.WriteObjectStart();

                var marshaller = FindingTypeAggregationMarshaller.Instance;
                marshaller.Marshall(requestObject.FindingTypeAggregation, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetImageLayerAggregation())
            {
                context.Writer.WritePropertyName("imageLayerAggregation");
                context.Writer.WriteObjectStart();

                var marshaller = ImageLayerAggregationMarshaller.Instance;
                marshaller.Marshall(requestObject.ImageLayerAggregation, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLambdaFunctionAggregation())
            {
                context.Writer.WritePropertyName("lambdaFunctionAggregation");
                context.Writer.WriteObjectStart();

                var marshaller = LambdaFunctionAggregationMarshaller.Instance;
                marshaller.Marshall(requestObject.LambdaFunctionAggregation, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLambdaLayerAggregation())
            {
                context.Writer.WritePropertyName("lambdaLayerAggregation");
                context.Writer.WriteObjectStart();

                var marshaller = LambdaLayerAggregationMarshaller.Instance;
                marshaller.Marshall(requestObject.LambdaLayerAggregation, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPackageAggregation())
            {
                context.Writer.WritePropertyName("packageAggregation");
                context.Writer.WriteObjectStart();

                var marshaller = PackageAggregationMarshaller.Instance;
                marshaller.Marshall(requestObject.PackageAggregation, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRepositoryAggregation())
            {
                context.Writer.WritePropertyName("repositoryAggregation");
                context.Writer.WriteObjectStart();

                var marshaller = RepositoryAggregationMarshaller.Instance;
                marshaller.Marshall(requestObject.RepositoryAggregation, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTitleAggregation())
            {
                context.Writer.WritePropertyName("titleAggregation");
                context.Writer.WriteObjectStart();

                var marshaller = TitleAggregationMarshaller.Instance;
                marshaller.Marshall(requestObject.TitleAggregation, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AggregationRequestMarshaller Instance = new AggregationRequestMarshaller();

    }
}