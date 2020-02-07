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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RoboMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.RoboMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SimulationJobRequest Marshaller
    /// </summary>       
    public class SimulationJobRequestMarshaller : IRequestMarshaller<SimulationJobRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SimulationJobRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDataSources())
            {
                context.Writer.WritePropertyName("dataSources");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDataSourcesListValue in requestObject.DataSources)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DataSourceConfigMarshaller.Instance;
                    marshaller.Marshall(requestObjectDataSourcesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetFailureBehavior())
            {
                context.Writer.WritePropertyName("failureBehavior");
                context.Writer.Write(requestObject.FailureBehavior);
            }

            if(requestObject.IsSetIamRole())
            {
                context.Writer.WritePropertyName("iamRole");
                context.Writer.Write(requestObject.IamRole);
            }

            if(requestObject.IsSetLoggingConfig())
            {
                context.Writer.WritePropertyName("loggingConfig");
                context.Writer.WriteObjectStart();

                var marshaller = LoggingConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.LoggingConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMaxJobDurationInSeconds())
            {
                context.Writer.WritePropertyName("maxJobDurationInSeconds");
                context.Writer.Write(requestObject.MaxJobDurationInSeconds);
            }

            if(requestObject.IsSetOutputLocation())
            {
                context.Writer.WritePropertyName("outputLocation");
                context.Writer.WriteObjectStart();

                var marshaller = OutputLocationMarshaller.Instance;
                marshaller.Marshall(requestObject.OutputLocation, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRobotApplications())
            {
                context.Writer.WritePropertyName("robotApplications");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRobotApplicationsListValue in requestObject.RobotApplications)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = RobotApplicationConfigMarshaller.Instance;
                    marshaller.Marshall(requestObjectRobotApplicationsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSimulationApplications())
            {
                context.Writer.WritePropertyName("simulationApplications");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSimulationApplicationsListValue in requestObject.SimulationApplications)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = SimulationApplicationConfigMarshaller.Instance;
                    marshaller.Marshall(requestObjectSimulationApplicationsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectTagsKvp in requestObject.Tags)
                {
                    context.Writer.WritePropertyName(requestObjectTagsKvp.Key);
                    var requestObjectTagsValue = requestObjectTagsKvp.Value;

                        context.Writer.Write(requestObjectTagsValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetUseDefaultApplications())
            {
                context.Writer.WritePropertyName("useDefaultApplications");
                context.Writer.Write(requestObject.UseDefaultApplications);
            }

            if(requestObject.IsSetVpcConfig())
            {
                context.Writer.WritePropertyName("vpcConfig");
                context.Writer.WriteObjectStart();

                var marshaller = VPCConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.VpcConfig, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static SimulationJobRequestMarshaller Instance = new SimulationJobRequestMarshaller();

    }
}