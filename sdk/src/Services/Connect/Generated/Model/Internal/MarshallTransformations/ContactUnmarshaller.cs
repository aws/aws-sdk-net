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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Contact Object
    /// </summary>  
    public class ContactUnmarshaller : IUnmarshaller<Contact, XmlUnmarshallerContext>, IUnmarshaller<Contact, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Contact IUnmarshaller<Contact, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Contact Unmarshall(JsonUnmarshallerContext context)
        {
            Contact unmarshalledObject = new Contact();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AdditionalEmailRecipients", targetDepth))
                {
                    var unmarshaller = AdditionalEmailRecipientsUnmarshaller.Instance;
                    unmarshalledObject.AdditionalEmailRecipients = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AgentInfo", targetDepth))
                {
                    var unmarshaller = AgentInfoUnmarshaller.Instance;
                    unmarshalledObject.AgentInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AnsweringMachineDetectionStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AnsweringMachineDetectionStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Campaign", targetDepth))
                {
                    var unmarshaller = CampaignUnmarshaller.Instance;
                    unmarshalledObject.Campaign = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Channel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Channel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ConnectedToSystemTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ConnectedToSystemTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ContactAssociationId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ContactAssociationId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Customer", targetDepth))
                {
                    var unmarshaller = CustomerUnmarshaller.Instance;
                    unmarshalledObject.Customer = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CustomerEndpoint", targetDepth))
                {
                    var unmarshaller = EndpointInfoUnmarshaller.Instance;
                    unmarshalledObject.CustomerEndpoint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CustomerId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CustomerId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CustomerVoiceActivity", targetDepth))
                {
                    var unmarshaller = CustomerVoiceActivityUnmarshaller.Instance;
                    unmarshalledObject.CustomerVoiceActivity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DisconnectDetails", targetDepth))
                {
                    var unmarshaller = DisconnectDetailsUnmarshaller.Instance;
                    unmarshalledObject.DisconnectDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DisconnectTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.DisconnectTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InitialContactId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InitialContactId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InitiationMethod", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InitiationMethod = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InitiationTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.InitiationTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastPausedTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastPausedTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastResumedTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastResumedTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastUpdateTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastUpdateTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PreviousContactId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PreviousContactId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QualityMetrics", targetDepth))
                {
                    var unmarshaller = QualityMetricsUnmarshaller.Instance;
                    unmarshalledObject.QualityMetrics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QueueInfo", targetDepth))
                {
                    var unmarshaller = QueueInfoUnmarshaller.Instance;
                    unmarshalledObject.QueueInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QueuePriority", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.QueuePriority = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QueueTimeAdjustmentSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.QueueTimeAdjustmentSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RelatedContactId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RelatedContactId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoutingCriteria", targetDepth))
                {
                    var unmarshaller = RoutingCriteriaUnmarshaller.Instance;
                    unmarshalledObject.RoutingCriteria = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScheduledTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ScheduledTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SegmentAttributes", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, SegmentAttributeValue, StringUnmarshaller, SegmentAttributeValueUnmarshaller>(StringUnmarshaller.Instance, SegmentAttributeValueUnmarshaller.Instance);
                    unmarshalledObject.SegmentAttributes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SystemEndpoint", targetDepth))
                {
                    var unmarshaller = EndpointInfoUnmarshaller.Instance;
                    unmarshalledObject.SystemEndpoint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Tags", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TotalPauseCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TotalPauseCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TotalPauseDurationInSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TotalPauseDurationInSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WisdomInfo", targetDepth))
                {
                    var unmarshaller = WisdomInfoUnmarshaller.Instance;
                    unmarshalledObject.WisdomInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ContactUnmarshaller _instance = new ContactUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ContactUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}