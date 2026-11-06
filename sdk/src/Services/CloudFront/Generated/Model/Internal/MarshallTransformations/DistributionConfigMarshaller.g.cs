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
    /// DistributionConfig Marshaller
    /// </summary>
    public partial class DistributionConfigMarshaller : IRequestMarshaller<DistributionConfig, XmlMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(DistributionConfig requestObject, XmlMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAliases())
            {
                context.Writer.WriteStartElement("Aliases");
                AliasesMarshaller.Instance.Marshall(requestObject.Aliases, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetAnycastIpListId())
            {
                context.Writer.WriteElementString("AnycastIpListId", StringUtils.FromString(requestObject.AnycastIpListId));
            }
            if (requestObject.IsSetCacheBehaviors())
            {
                context.Writer.WriteStartElement("CacheBehaviors");
                CacheBehaviorsMarshaller.Instance.Marshall(requestObject.CacheBehaviors, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetCacheTagConfig())
            {
                context.Writer.WriteStartElement("CacheTagConfig");
                CacheTagConfigMarshaller.Instance.Marshall(requestObject.CacheTagConfig, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetCallerReference())
            {
                context.Writer.WriteElementString("CallerReference", StringUtils.FromString(requestObject.CallerReference));
            }
            if (requestObject.IsSetComment())
            {
                context.Writer.WriteElementString("Comment", StringUtils.FromString(requestObject.Comment));
            }
            if (requestObject.IsSetConnectionFunctionAssociation())
            {
                context.Writer.WriteStartElement("ConnectionFunctionAssociation");
                ConnectionFunctionAssociationMarshaller.Instance.Marshall(requestObject.ConnectionFunctionAssociation, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetConnectionMode())
            {
                context.Writer.WriteElementString("ConnectionMode", StringUtils.FromString(requestObject.ConnectionMode));
            }
            if (requestObject.IsSetContinuousDeploymentPolicyId())
            {
                context.Writer.WriteElementString("ContinuousDeploymentPolicyId", StringUtils.FromString(requestObject.ContinuousDeploymentPolicyId));
            }
            if (requestObject.IsSetCustomErrorResponses())
            {
                context.Writer.WriteStartElement("CustomErrorResponses");
                CustomErrorResponsesMarshaller.Instance.Marshall(requestObject.CustomErrorResponses, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetDefaultCacheBehavior())
            {
                context.Writer.WriteStartElement("DefaultCacheBehavior");
                DefaultCacheBehaviorMarshaller.Instance.Marshall(requestObject.DefaultCacheBehavior, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetDefaultRootObject())
            {
                context.Writer.WriteElementString("DefaultRootObject", StringUtils.FromString(requestObject.DefaultRootObject));
            }
            if (requestObject.IsSetEnabled())
            {
                context.Writer.WriteElementString("Enabled", StringUtils.FromBool(requestObject.Enabled.Value));
            }
            if (requestObject.IsSetHttpVersion())
            {
                context.Writer.WriteElementString("HttpVersion", StringUtils.FromString(requestObject.HttpVersion));
            }
            if (requestObject.IsSetIsIPV6Enabled())
            {
                context.Writer.WriteElementString("IsIPV6Enabled", StringUtils.FromBool(requestObject.IsIPV6Enabled.Value));
            }
            if (requestObject.IsSetLogging())
            {
                context.Writer.WriteStartElement("Logging");
                LoggingConfigMarshaller.Instance.Marshall(requestObject.Logging, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetOriginGroups())
            {
                context.Writer.WriteStartElement("OriginGroups");
                OriginGroupsMarshaller.Instance.Marshall(requestObject.OriginGroups, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetOrigins())
            {
                context.Writer.WriteStartElement("Origins");
                OriginsMarshaller.Instance.Marshall(requestObject.Origins, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetPriceClass())
            {
                context.Writer.WriteElementString("PriceClass", StringUtils.FromString(requestObject.PriceClass));
            }
            if (requestObject.IsSetRestrictions())
            {
                context.Writer.WriteStartElement("Restrictions");
                RestrictionsMarshaller.Instance.Marshall(requestObject.Restrictions, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetStaging())
            {
                context.Writer.WriteElementString("Staging", StringUtils.FromBool(requestObject.Staging.Value));
            }
            if (requestObject.IsSetTenantConfig())
            {
                context.Writer.WriteStartElement("TenantConfig");
                TenantConfigMarshaller.Instance.Marshall(requestObject.TenantConfig, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetViewerCertificate())
            {
                context.Writer.WriteStartElement("ViewerCertificate");
                ViewerCertificateMarshaller.Instance.Marshall(requestObject.ViewerCertificate, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetViewerMtlsConfig())
            {
                context.Writer.WriteStartElement("ViewerMtlsConfig");
                ViewerMtlsConfigMarshaller.Instance.Marshall(requestObject.ViewerMtlsConfig, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetWebACLId())
            {
                context.Writer.WriteElementString("WebACLId", StringUtils.FromString(requestObject.WebACLId));
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static DistributionConfigMarshaller Instance = new DistributionConfigMarshaller();
    }
}
