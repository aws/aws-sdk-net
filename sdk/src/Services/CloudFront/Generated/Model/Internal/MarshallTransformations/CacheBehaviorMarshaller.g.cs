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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.CloudFront.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CacheBehavior Marshaller
    /// </summary>
    public partial class CacheBehaviorMarshaller : IRequestMarshaller<CacheBehavior, XmlMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(CacheBehavior requestObject, XmlMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAllowedMethods())
            {
                context.Writer.WriteStartElement("AllowedMethods");
                AllowedMethodsMarshaller.Instance.Marshall(requestObject.AllowedMethods, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetCachePolicyId())
            {
                context.Writer.WriteElementString("CachePolicyId", StringUtils.FromString(requestObject.CachePolicyId));
            }
            if (requestObject.IsSetCompress())
            {
                context.Writer.WriteElementString("Compress", StringUtils.FromBool(requestObject.Compress.Value));
            }
            if (requestObject.IsSetDefaultTTL())
            {
                context.Writer.WriteElementString("DefaultTTL", StringUtils.FromLong(requestObject.DefaultTTL.Value));
            }
            if (requestObject.IsSetFieldLevelEncryptionId())
            {
                context.Writer.WriteElementString("FieldLevelEncryptionId", StringUtils.FromString(requestObject.FieldLevelEncryptionId));
            }
            if (requestObject.IsSetForwardedValues())
            {
                context.Writer.WriteStartElement("ForwardedValues");
                ForwardedValuesMarshaller.Instance.Marshall(requestObject.ForwardedValues, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetFunctionAssociations())
            {
                context.Writer.WriteStartElement("FunctionAssociations");
                FunctionAssociationsMarshaller.Instance.Marshall(requestObject.FunctionAssociations, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetGrpcConfig())
            {
                context.Writer.WriteStartElement("GrpcConfig");
                GrpcConfigMarshaller.Instance.Marshall(requestObject.GrpcConfig, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetLambdaFunctionAssociations())
            {
                context.Writer.WriteStartElement("LambdaFunctionAssociations");
                LambdaFunctionAssociationsMarshaller.Instance.Marshall(requestObject.LambdaFunctionAssociations, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetMaxTTL())
            {
                context.Writer.WriteElementString("MaxTTL", StringUtils.FromLong(requestObject.MaxTTL.Value));
            }
            if (requestObject.IsSetMinTTL())
            {
                context.Writer.WriteElementString("MinTTL", StringUtils.FromLong(requestObject.MinTTL.Value));
            }
            if (requestObject.IsSetOriginRequestPolicyId())
            {
                context.Writer.WriteElementString("OriginRequestPolicyId", StringUtils.FromString(requestObject.OriginRequestPolicyId));
            }
            if (requestObject.IsSetPathPattern())
            {
                context.Writer.WriteElementString("PathPattern", StringUtils.FromString(requestObject.PathPattern));
            }
            if (requestObject.IsSetRealtimeLogConfigArn())
            {
                context.Writer.WriteElementString("RealtimeLogConfigArn", StringUtils.FromString(requestObject.RealtimeLogConfigArn));
            }
            if (requestObject.IsSetResponseHeadersPolicyId())
            {
                context.Writer.WriteElementString("ResponseHeadersPolicyId", StringUtils.FromString(requestObject.ResponseHeadersPolicyId));
            }
            if (requestObject.IsSetSmoothStreaming())
            {
                context.Writer.WriteElementString("SmoothStreaming", StringUtils.FromBool(requestObject.SmoothStreaming.Value));
            }
            if (requestObject.IsSetTargetOriginId())
            {
                context.Writer.WriteElementString("TargetOriginId", StringUtils.FromString(requestObject.TargetOriginId));
            }
            if (requestObject.IsSetTrustedKeyGroups())
            {
                context.Writer.WriteStartElement("TrustedKeyGroups");
                TrustedKeyGroupsMarshaller.Instance.Marshall(requestObject.TrustedKeyGroups, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetTrustedSigners())
            {
                context.Writer.WriteStartElement("TrustedSigners");
                TrustedSignersMarshaller.Instance.Marshall(requestObject.TrustedSigners, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetViewerProtocolPolicy())
            {
                context.Writer.WriteElementString("ViewerProtocolPolicy", StringUtils.FromString(requestObject.ViewerProtocolPolicy));
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static CacheBehaviorMarshaller Instance = new CacheBehaviorMarshaller();
    }
}
