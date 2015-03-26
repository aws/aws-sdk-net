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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */


using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.CloudWatch;
using Amazon.CloudWatch.Model;
using Amazon.CloudWatch.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;

using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public class CloudWatchMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("monitoring-2010-08-01.normal.json", "monitoring.customizations.json");
        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudWatch")]
        public void DeleteAlarmsMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteAlarms");

            var request = InstantiateClassGenerator.Execute<DeleteAlarmsRequest>();
            var marshaller = new DeleteAlarmsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudWatch")]
        public void DescribeAlarmHistoryMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAlarmHistory");

            var request = InstantiateClassGenerator.Execute<DescribeAlarmHistoryRequest>();
            var marshaller = new DescribeAlarmHistoryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeAlarmHistoryResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeAlarmHistoryResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudWatch")]
        public void DescribeAlarmsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAlarms");

            var request = InstantiateClassGenerator.Execute<DescribeAlarmsRequest>();
            var marshaller = new DescribeAlarmsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeAlarmsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeAlarmsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudWatch")]
        public void DescribeAlarmsForMetricMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAlarmsForMetric");

            var request = InstantiateClassGenerator.Execute<DescribeAlarmsForMetricRequest>();
            var marshaller = new DescribeAlarmsForMetricRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeAlarmsForMetricResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeAlarmsForMetricResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudWatch")]
        public void DisableAlarmActionsMarshallTest()
        {
            var operation = service_model.FindOperation("DisableAlarmActions");

            var request = InstantiateClassGenerator.Execute<DisableAlarmActionsRequest>();
            var marshaller = new DisableAlarmActionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudWatch")]
        public void EnableAlarmActionsMarshallTest()
        {
            var operation = service_model.FindOperation("EnableAlarmActions");

            var request = InstantiateClassGenerator.Execute<EnableAlarmActionsRequest>();
            var marshaller = new EnableAlarmActionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudWatch")]
        public void GetMetricStatisticsMarshallTest()
        {
            var operation = service_model.FindOperation("GetMetricStatistics");

            var request = InstantiateClassGenerator.Execute<GetMetricStatisticsRequest>();
            var marshaller = new GetMetricStatisticsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetMetricStatisticsResponseUnmarshaller.Instance.Unmarshall(context)
                as GetMetricStatisticsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudWatch")]
        public void ListMetricsMarshallTest()
        {
            var operation = service_model.FindOperation("ListMetrics");

            var request = InstantiateClassGenerator.Execute<ListMetricsRequest>();
            var marshaller = new ListMetricsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListMetricsResponseUnmarshaller.Instance.Unmarshall(context)
                as ListMetricsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudWatch")]
        public void PutMetricAlarmMarshallTest()
        {
            var operation = service_model.FindOperation("PutMetricAlarm");

            var request = InstantiateClassGenerator.Execute<PutMetricAlarmRequest>();
            var marshaller = new PutMetricAlarmRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudWatch")]
        public void PutMetricDataMarshallTest()
        {
            var operation = service_model.FindOperation("PutMetricData");

            var request = InstantiateClassGenerator.Execute<PutMetricDataRequest>();
            var marshaller = new PutMetricDataRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("CloudWatch")]
        public void SetAlarmStateMarshallTest()
        {
            var operation = service_model.FindOperation("SetAlarmState");

            var request = InstantiateClassGenerator.Execute<SetAlarmStateRequest>();
            var marshaller = new SetAlarmStateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        
    }
}