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

using Amazon.Route53.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.Route53.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HealthCheckConfig Marshaller
    /// </summary>
    public partial class HealthCheckConfigMarshaller : IRequestMarshaller<HealthCheckConfig, XmlMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(HealthCheckConfig requestObject, XmlMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetIPAddress())
            {
                context.Writer.WriteElementString("IPAddress", StringUtils.FromString(requestObject.IPAddress));
            }
            if (requestObject.IsSetPort())
            {
                context.Writer.WriteElementString("Port", StringUtils.FromInt(requestObject.Port.Value));
            }
            if (requestObject.IsSetType())
            {
                context.Writer.WriteElementString("Type", StringUtils.FromString(requestObject.Type));
            }
            if (requestObject.IsSetResourcePath())
            {
                context.Writer.WriteElementString("ResourcePath", StringUtils.FromString(requestObject.ResourcePath));
            }
            if (requestObject.IsSetFullyQualifiedDomainName())
            {
                context.Writer.WriteElementString("FullyQualifiedDomainName", StringUtils.FromString(requestObject.FullyQualifiedDomainName));
            }
            if (requestObject.IsSetSearchString())
            {
                context.Writer.WriteElementString("SearchString", StringUtils.FromString(requestObject.SearchString));
            }
            if (requestObject.IsSetRequestInterval())
            {
                context.Writer.WriteElementString("RequestInterval", StringUtils.FromInt(requestObject.RequestInterval.Value));
            }
            if (requestObject.IsSetFailureThreshold())
            {
                context.Writer.WriteElementString("FailureThreshold", StringUtils.FromInt(requestObject.FailureThreshold.Value));
            }
            if (requestObject.IsSetMeasureLatency())
            {
                context.Writer.WriteElementString("MeasureLatency", StringUtils.FromBool(requestObject.MeasureLatency.Value));
            }
            if (requestObject.IsSetInverted())
            {
                context.Writer.WriteElementString("Inverted", StringUtils.FromBool(requestObject.Inverted.Value));
            }
            if (requestObject.IsSetDisabled())
            {
                context.Writer.WriteElementString("Disabled", StringUtils.FromBool(requestObject.Disabled.Value));
            }
            if (requestObject.IsSetHealthThreshold())
            {
                context.Writer.WriteElementString("HealthThreshold", StringUtils.FromInt(requestObject.HealthThreshold.Value));
            }
            if (requestObject.IsSetChildHealthChecks())
            {
                var requestObjectChildHealthChecks = requestObject.ChildHealthChecks;
                context.Writer.WriteStartElement("ChildHealthChecks");
                foreach (var requestObjectChildHealthChecksValue in requestObjectChildHealthChecks)
                {
                    context.Writer.WriteStartElement("ChildHealthCheck");
                    context.Writer.WriteValue(requestObjectChildHealthChecksValue);
                    context.Writer.WriteEndElement();
                }
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetEnableSNI())
            {
                context.Writer.WriteElementString("EnableSNI", StringUtils.FromBool(requestObject.EnableSNI.Value));
            }
            if (requestObject.IsSetRegions())
            {
                var requestObjectRegions = requestObject.Regions;
                context.Writer.WriteStartElement("Regions");
                foreach (var requestObjectRegionsValue in requestObjectRegions)
                {
                    context.Writer.WriteStartElement("Region");
                    context.Writer.WriteValue(requestObjectRegionsValue);
                    context.Writer.WriteEndElement();
                }
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetAlarmIdentifier())
            {
                context.Writer.WriteStartElement("AlarmIdentifier");
                AlarmIdentifierMarshaller.Instance.Marshall(requestObject.AlarmIdentifier, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetInsufficientDataHealthStatus())
            {
                context.Writer.WriteElementString("InsufficientDataHealthStatus", StringUtils.FromString(requestObject.InsufficientDataHealthStatus));
            }
            if (requestObject.IsSetRoutingControlArn())
            {
                context.Writer.WriteElementString("RoutingControlArn", StringUtils.FromString(requestObject.RoutingControlArn));
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static HealthCheckConfigMarshaller Instance = new HealthCheckConfigMarshaller();
    }
}
