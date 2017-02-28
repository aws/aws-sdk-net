/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MTurk.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MTurk.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for HIT Object
    /// </summary>  
    public class HITUnmarshaller : IUnmarshaller<HIT, XmlUnmarshallerContext>, IUnmarshaller<HIT, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        HIT IUnmarshaller<HIT, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public HIT Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            HIT unmarshalledObject = new HIT();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AssignmentDurationInSeconds", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.AssignmentDurationInSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AutoApprovalDelayInSeconds", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.AutoApprovalDelayInSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Expiration", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.Expiration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HITGroupId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HITGroupId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HITId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HITId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HITLayoutId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HITLayoutId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HITReviewStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HITReviewStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HITStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HITStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HITTypeId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HITTypeId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Keywords", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Keywords = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxAssignments", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxAssignments = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NumberOfAssignmentsAvailable", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NumberOfAssignmentsAvailable = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NumberOfAssignmentsCompleted", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NumberOfAssignmentsCompleted = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NumberOfAssignmentsPending", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NumberOfAssignmentsPending = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QualificationRequirements", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<QualificationRequirement, QualificationRequirementUnmarshaller>(QualificationRequirementUnmarshaller.Instance);
                    unmarshalledObject.QualificationRequirements = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Question", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Question = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RequesterAnnotation", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RequesterAnnotation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Reward", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Reward = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Title", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Title = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static HITUnmarshaller _instance = new HITUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static HITUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}