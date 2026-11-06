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
    /// ResourceRecordSet Marshaller
    /// </summary>
    public partial class ResourceRecordSetMarshaller : IRequestMarshaller<ResourceRecordSet, XmlMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(ResourceRecordSet requestObject, XmlMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetName())
            {
                context.Writer.WriteElementString("Name", StringUtils.FromString(requestObject.Name));
            }
            if (requestObject.IsSetType())
            {
                context.Writer.WriteElementString("Type", StringUtils.FromString(requestObject.Type));
            }
            if (requestObject.IsSetSetIdentifier())
            {
                context.Writer.WriteElementString("SetIdentifier", StringUtils.FromString(requestObject.SetIdentifier));
            }
            if (requestObject.IsSetWeight())
            {
                context.Writer.WriteElementString("Weight", StringUtils.FromLong(requestObject.Weight.Value));
            }
            if (requestObject.IsSetRegion())
            {
                context.Writer.WriteElementString("Region", StringUtils.FromString(requestObject.Region));
            }
            if (requestObject.IsSetGeoLocation())
            {
                context.Writer.WriteStartElement("GeoLocation");
                GeoLocationMarshaller.Instance.Marshall(requestObject.GeoLocation, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetFailover())
            {
                context.Writer.WriteElementString("Failover", StringUtils.FromString(requestObject.Failover));
            }
            if (requestObject.IsSetMultiValueAnswer())
            {
                context.Writer.WriteElementString("MultiValueAnswer", StringUtils.FromBool(requestObject.MultiValueAnswer.Value));
            }
            if (requestObject.IsSetTTL())
            {
                context.Writer.WriteElementString("TTL", StringUtils.FromLong(requestObject.TTL.Value));
            }
            if (requestObject.IsSetResourceRecords())
            {
                var requestObjectResourceRecords = requestObject.ResourceRecords;
                context.Writer.WriteStartElement("ResourceRecords");
                foreach (var requestObjectResourceRecordsValue in requestObjectResourceRecords)
                {
                    if (requestObjectResourceRecordsValue != null)
                    {
                        context.Writer.WriteStartElement("ResourceRecord");
                        ResourceRecordMarshaller.Instance.Marshall(requestObjectResourceRecordsValue, context);
                        context.Writer.WriteEndElement();
                    }
                }
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetAliasTarget())
            {
                context.Writer.WriteStartElement("AliasTarget");
                AliasTargetMarshaller.Instance.Marshall(requestObject.AliasTarget, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetHealthCheckId())
            {
                context.Writer.WriteElementString("HealthCheckId", StringUtils.FromString(requestObject.HealthCheckId));
            }
            if (requestObject.IsSetTrafficPolicyInstanceId())
            {
                context.Writer.WriteElementString("TrafficPolicyInstanceId", StringUtils.FromString(requestObject.TrafficPolicyInstanceId));
            }
            if (requestObject.IsSetCidrRoutingConfig())
            {
                context.Writer.WriteStartElement("CidrRoutingConfig");
                CidrRoutingConfigMarshaller.Instance.Marshall(requestObject.CidrRoutingConfig, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetGeoProximityLocation())
            {
                context.Writer.WriteStartElement("GeoProximityLocation");
                GeoProximityLocationMarshaller.Instance.Marshall(requestObject.GeoProximityLocation, context);
                context.Writer.WriteEndElement();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static ResourceRecordSetMarshaller Instance = new ResourceRecordSetMarshaller();
    }
}
