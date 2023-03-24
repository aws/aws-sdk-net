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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */


using System;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.RDS;
using Amazon.RDS.Model;
using Amazon.RDS.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;

using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public class RDSMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("rds");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void AddRoleToDBClusterMarshallTest()
        {
            var operation = service_model.FindOperation("AddRoleToDBCluster");

            var request = InstantiateClassGenerator.Execute<AddRoleToDBClusterRequest>();
            var marshaller = new AddRoleToDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void AddRoleToDBCluster_DBClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AddRoleToDBCluster");

            var request = InstantiateClassGenerator.Execute<AddRoleToDBClusterRequest>();
            var marshaller = new AddRoleToDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AddRoleToDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void AddRoleToDBCluster_DBClusterRoleAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AddRoleToDBCluster");

            var request = InstantiateClassGenerator.Execute<AddRoleToDBClusterRequest>();
            var marshaller = new AddRoleToDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterRoleAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AddRoleToDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void AddRoleToDBCluster_DBClusterRoleQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AddRoleToDBCluster");

            var request = InstantiateClassGenerator.Execute<AddRoleToDBClusterRequest>();
            var marshaller = new AddRoleToDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterRoleQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AddRoleToDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void AddRoleToDBCluster_InvalidDBClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AddRoleToDBCluster");

            var request = InstantiateClassGenerator.Execute<AddRoleToDBClusterRequest>();
            var marshaller = new AddRoleToDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AddRoleToDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void AddRoleToDBInstanceMarshallTest()
        {
            var operation = service_model.FindOperation("AddRoleToDBInstance");

            var request = InstantiateClassGenerator.Execute<AddRoleToDBInstanceRequest>();
            var marshaller = new AddRoleToDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void AddRoleToDBInstance_DBInstanceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AddRoleToDBInstance");

            var request = InstantiateClassGenerator.Execute<AddRoleToDBInstanceRequest>();
            var marshaller = new AddRoleToDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AddRoleToDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void AddRoleToDBInstance_DBInstanceRoleAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AddRoleToDBInstance");

            var request = InstantiateClassGenerator.Execute<AddRoleToDBInstanceRequest>();
            var marshaller = new AddRoleToDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceRoleAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AddRoleToDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void AddRoleToDBInstance_DBInstanceRoleQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AddRoleToDBInstance");

            var request = InstantiateClassGenerator.Execute<AddRoleToDBInstanceRequest>();
            var marshaller = new AddRoleToDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceRoleQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AddRoleToDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void AddRoleToDBInstance_InvalidDBInstanceStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AddRoleToDBInstance");

            var request = InstantiateClassGenerator.Execute<AddRoleToDBInstanceRequest>();
            var marshaller = new AddRoleToDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBInstanceStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AddRoleToDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void AddSourceIdentifierToSubscriptionMarshallTest()
        {
            var operation = service_model.FindOperation("AddSourceIdentifierToSubscription");

            var request = InstantiateClassGenerator.Execute<AddSourceIdentifierToSubscriptionRequest>();
            var marshaller = new AddSourceIdentifierToSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = AddSourceIdentifierToSubscriptionResponseUnmarshaller.Instance.Unmarshall(context)
                as AddSourceIdentifierToSubscriptionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void AddSourceIdentifierToSubscription_SourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AddSourceIdentifierToSubscription");

            var request = InstantiateClassGenerator.Execute<AddSourceIdentifierToSubscriptionRequest>();
            var marshaller = new AddSourceIdentifierToSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AddSourceIdentifierToSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void AddSourceIdentifierToSubscription_SubscriptionNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AddSourceIdentifierToSubscription");

            var request = InstantiateClassGenerator.Execute<AddSourceIdentifierToSubscriptionRequest>();
            var marshaller = new AddSourceIdentifierToSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SubscriptionNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AddSourceIdentifierToSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void AddTagsToResourceMarshallTest()
        {
            var operation = service_model.FindOperation("AddTagsToResource");

            var request = InstantiateClassGenerator.Execute<AddTagsToResourceRequest>();
            var marshaller = new AddTagsToResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void AddTagsToResource_BlueGreenDeploymentNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AddTagsToResource");

            var request = InstantiateClassGenerator.Execute<AddTagsToResourceRequest>();
            var marshaller = new AddTagsToResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BlueGreenDeploymentNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AddTagsToResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void AddTagsToResource_DBClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AddTagsToResource");

            var request = InstantiateClassGenerator.Execute<AddTagsToResourceRequest>();
            var marshaller = new AddTagsToResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AddTagsToResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void AddTagsToResource_DBInstanceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AddTagsToResource");

            var request = InstantiateClassGenerator.Execute<AddTagsToResourceRequest>();
            var marshaller = new AddTagsToResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AddTagsToResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void AddTagsToResource_DBProxyNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AddTagsToResource");

            var request = InstantiateClassGenerator.Execute<AddTagsToResourceRequest>();
            var marshaller = new AddTagsToResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBProxyNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AddTagsToResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void AddTagsToResource_DBProxyTargetGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AddTagsToResource");

            var request = InstantiateClassGenerator.Execute<AddTagsToResourceRequest>();
            var marshaller = new AddTagsToResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBProxyTargetGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AddTagsToResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void AddTagsToResource_DBSnapshotNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AddTagsToResource");

            var request = InstantiateClassGenerator.Execute<AddTagsToResourceRequest>();
            var marshaller = new AddTagsToResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSnapshotNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AddTagsToResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ApplyPendingMaintenanceActionMarshallTest()
        {
            var operation = service_model.FindOperation("ApplyPendingMaintenanceAction");

            var request = InstantiateClassGenerator.Execute<ApplyPendingMaintenanceActionRequest>();
            var marshaller = new ApplyPendingMaintenanceActionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ApplyPendingMaintenanceActionResponseUnmarshaller.Instance.Unmarshall(context)
                as ApplyPendingMaintenanceActionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ApplyPendingMaintenanceAction_InvalidDBClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ApplyPendingMaintenanceAction");

            var request = InstantiateClassGenerator.Execute<ApplyPendingMaintenanceActionRequest>();
            var marshaller = new ApplyPendingMaintenanceActionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ApplyPendingMaintenanceActionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ApplyPendingMaintenanceAction_InvalidDBInstanceStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ApplyPendingMaintenanceAction");

            var request = InstantiateClassGenerator.Execute<ApplyPendingMaintenanceActionRequest>();
            var marshaller = new ApplyPendingMaintenanceActionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBInstanceStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ApplyPendingMaintenanceActionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ApplyPendingMaintenanceAction_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ApplyPendingMaintenanceAction");

            var request = InstantiateClassGenerator.Execute<ApplyPendingMaintenanceActionRequest>();
            var marshaller = new ApplyPendingMaintenanceActionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ApplyPendingMaintenanceActionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void AuthorizeDBSecurityGroupIngressMarshallTest()
        {
            var operation = service_model.FindOperation("AuthorizeDBSecurityGroupIngress");

            var request = InstantiateClassGenerator.Execute<AuthorizeDBSecurityGroupIngressRequest>();
            var marshaller = new AuthorizeDBSecurityGroupIngressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = AuthorizeDBSecurityGroupIngressResponseUnmarshaller.Instance.Unmarshall(context)
                as AuthorizeDBSecurityGroupIngressResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void AuthorizeDBSecurityGroupIngress_AuthorizationAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AuthorizeDBSecurityGroupIngress");

            var request = InstantiateClassGenerator.Execute<AuthorizeDBSecurityGroupIngressRequest>();
            var marshaller = new AuthorizeDBSecurityGroupIngressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AuthorizationAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AuthorizeDBSecurityGroupIngressResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void AuthorizeDBSecurityGroupIngress_AuthorizationQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AuthorizeDBSecurityGroupIngress");

            var request = InstantiateClassGenerator.Execute<AuthorizeDBSecurityGroupIngressRequest>();
            var marshaller = new AuthorizeDBSecurityGroupIngressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AuthorizationQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AuthorizeDBSecurityGroupIngressResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void AuthorizeDBSecurityGroupIngress_DBSecurityGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AuthorizeDBSecurityGroupIngress");

            var request = InstantiateClassGenerator.Execute<AuthorizeDBSecurityGroupIngressRequest>();
            var marshaller = new AuthorizeDBSecurityGroupIngressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSecurityGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AuthorizeDBSecurityGroupIngressResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void AuthorizeDBSecurityGroupIngress_InvalidDBSecurityGroupStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AuthorizeDBSecurityGroupIngress");

            var request = InstantiateClassGenerator.Execute<AuthorizeDBSecurityGroupIngressRequest>();
            var marshaller = new AuthorizeDBSecurityGroupIngressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBSecurityGroupStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AuthorizeDBSecurityGroupIngressResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void BacktrackDBClusterMarshallTest()
        {
            var operation = service_model.FindOperation("BacktrackDBCluster");

            var request = InstantiateClassGenerator.Execute<BacktrackDBClusterRequest>();
            var marshaller = new BacktrackDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = BacktrackDBClusterResponseUnmarshaller.Instance.Unmarshall(context)
                as BacktrackDBClusterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void BacktrackDBCluster_DBClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BacktrackDBCluster");

            var request = InstantiateClassGenerator.Execute<BacktrackDBClusterRequest>();
            var marshaller = new BacktrackDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = BacktrackDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void BacktrackDBCluster_InvalidDBClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BacktrackDBCluster");

            var request = InstantiateClassGenerator.Execute<BacktrackDBClusterRequest>();
            var marshaller = new BacktrackDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = BacktrackDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CancelExportTaskMarshallTest()
        {
            var operation = service_model.FindOperation("CancelExportTask");

            var request = InstantiateClassGenerator.Execute<CancelExportTaskRequest>();
            var marshaller = new CancelExportTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CancelExportTaskResponseUnmarshaller.Instance.Unmarshall(context)
                as CancelExportTaskResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CancelExportTask_ExportTaskNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CancelExportTask");

            var request = InstantiateClassGenerator.Execute<CancelExportTaskRequest>();
            var marshaller = new CancelExportTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ExportTaskNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CancelExportTaskResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CancelExportTask_InvalidExportTaskStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CancelExportTask");

            var request = InstantiateClassGenerator.Execute<CancelExportTaskRequest>();
            var marshaller = new CancelExportTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidExportTaskStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CancelExportTaskResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CopyDBClusterParameterGroupMarshallTest()
        {
            var operation = service_model.FindOperation("CopyDBClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<CopyDBClusterParameterGroupRequest>();
            var marshaller = new CopyDBClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CopyDBClusterParameterGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as CopyDBClusterParameterGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CopyDBClusterParameterGroup_DBParameterGroupAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CopyDBClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<CopyDBClusterParameterGroupRequest>();
            var marshaller = new CopyDBClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBParameterGroupAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CopyDBClusterParameterGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CopyDBClusterParameterGroup_DBParameterGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CopyDBClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<CopyDBClusterParameterGroupRequest>();
            var marshaller = new CopyDBClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBParameterGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CopyDBClusterParameterGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CopyDBClusterParameterGroup_DBParameterGroupQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CopyDBClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<CopyDBClusterParameterGroupRequest>();
            var marshaller = new CopyDBClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBParameterGroupQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CopyDBClusterParameterGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CopyDBClusterSnapshotMarshallTest()
        {
            var operation = service_model.FindOperation("CopyDBClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<CopyDBClusterSnapshotRequest>();
            var marshaller = new CopyDBClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CopyDBClusterSnapshotResponseUnmarshaller.Instance.Unmarshall(context)
                as CopyDBClusterSnapshotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CopyDBClusterSnapshot_DBClusterSnapshotAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CopyDBClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<CopyDBClusterSnapshotRequest>();
            var marshaller = new CopyDBClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterSnapshotAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CopyDBClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CopyDBClusterSnapshot_DBClusterSnapshotNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CopyDBClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<CopyDBClusterSnapshotRequest>();
            var marshaller = new CopyDBClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterSnapshotNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CopyDBClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CopyDBClusterSnapshot_InvalidDBClusterSnapshotStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CopyDBClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<CopyDBClusterSnapshotRequest>();
            var marshaller = new CopyDBClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterSnapshotStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CopyDBClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CopyDBClusterSnapshot_InvalidDBClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CopyDBClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<CopyDBClusterSnapshotRequest>();
            var marshaller = new CopyDBClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CopyDBClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CopyDBClusterSnapshot_KMSKeyNotAccessibleExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CopyDBClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<CopyDBClusterSnapshotRequest>();
            var marshaller = new CopyDBClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("KMSKeyNotAccessibleException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CopyDBClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CopyDBClusterSnapshot_SnapshotQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CopyDBClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<CopyDBClusterSnapshotRequest>();
            var marshaller = new CopyDBClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SnapshotQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CopyDBClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CopyDBParameterGroupMarshallTest()
        {
            var operation = service_model.FindOperation("CopyDBParameterGroup");

            var request = InstantiateClassGenerator.Execute<CopyDBParameterGroupRequest>();
            var marshaller = new CopyDBParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CopyDBParameterGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as CopyDBParameterGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CopyDBParameterGroup_DBParameterGroupAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CopyDBParameterGroup");

            var request = InstantiateClassGenerator.Execute<CopyDBParameterGroupRequest>();
            var marshaller = new CopyDBParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBParameterGroupAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CopyDBParameterGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CopyDBParameterGroup_DBParameterGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CopyDBParameterGroup");

            var request = InstantiateClassGenerator.Execute<CopyDBParameterGroupRequest>();
            var marshaller = new CopyDBParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBParameterGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CopyDBParameterGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CopyDBParameterGroup_DBParameterGroupQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CopyDBParameterGroup");

            var request = InstantiateClassGenerator.Execute<CopyDBParameterGroupRequest>();
            var marshaller = new CopyDBParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBParameterGroupQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CopyDBParameterGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CopyDBSnapshotMarshallTest()
        {
            var operation = service_model.FindOperation("CopyDBSnapshot");

            var request = InstantiateClassGenerator.Execute<CopyDBSnapshotRequest>();
            var marshaller = new CopyDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CopyDBSnapshotResponseUnmarshaller.Instance.Unmarshall(context)
                as CopyDBSnapshotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CopyDBSnapshot_CustomAvailabilityZoneNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CopyDBSnapshot");

            var request = InstantiateClassGenerator.Execute<CopyDBSnapshotRequest>();
            var marshaller = new CopyDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CustomAvailabilityZoneNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CopyDBSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CopyDBSnapshot_DBSnapshotAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CopyDBSnapshot");

            var request = InstantiateClassGenerator.Execute<CopyDBSnapshotRequest>();
            var marshaller = new CopyDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSnapshotAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CopyDBSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CopyDBSnapshot_DBSnapshotNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CopyDBSnapshot");

            var request = InstantiateClassGenerator.Execute<CopyDBSnapshotRequest>();
            var marshaller = new CopyDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSnapshotNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CopyDBSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CopyDBSnapshot_InvalidDBSnapshotStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CopyDBSnapshot");

            var request = InstantiateClassGenerator.Execute<CopyDBSnapshotRequest>();
            var marshaller = new CopyDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBSnapshotStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CopyDBSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CopyDBSnapshot_KMSKeyNotAccessibleExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CopyDBSnapshot");

            var request = InstantiateClassGenerator.Execute<CopyDBSnapshotRequest>();
            var marshaller = new CopyDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("KMSKeyNotAccessibleException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CopyDBSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CopyDBSnapshot_SnapshotQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CopyDBSnapshot");

            var request = InstantiateClassGenerator.Execute<CopyDBSnapshotRequest>();
            var marshaller = new CopyDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SnapshotQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CopyDBSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CopyOptionGroupMarshallTest()
        {
            var operation = service_model.FindOperation("CopyOptionGroup");

            var request = InstantiateClassGenerator.Execute<CopyOptionGroupRequest>();
            var marshaller = new CopyOptionGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CopyOptionGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as CopyOptionGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CopyOptionGroup_OptionGroupAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CopyOptionGroup");

            var request = InstantiateClassGenerator.Execute<CopyOptionGroupRequest>();
            var marshaller = new CopyOptionGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OptionGroupAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CopyOptionGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CopyOptionGroup_OptionGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CopyOptionGroup");

            var request = InstantiateClassGenerator.Execute<CopyOptionGroupRequest>();
            var marshaller = new CopyOptionGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OptionGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CopyOptionGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CopyOptionGroup_OptionGroupQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CopyOptionGroup");

            var request = InstantiateClassGenerator.Execute<CopyOptionGroupRequest>();
            var marshaller = new CopyOptionGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OptionGroupQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CopyOptionGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateBlueGreenDeploymentMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBlueGreenDeployment");

            var request = InstantiateClassGenerator.Execute<CreateBlueGreenDeploymentRequest>();
            var marshaller = new CreateBlueGreenDeploymentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateBlueGreenDeploymentResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateBlueGreenDeploymentResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateBlueGreenDeployment_BlueGreenDeploymentAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBlueGreenDeployment");

            var request = InstantiateClassGenerator.Execute<CreateBlueGreenDeploymentRequest>();
            var marshaller = new CreateBlueGreenDeploymentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BlueGreenDeploymentAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateBlueGreenDeploymentResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateBlueGreenDeployment_DBClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBlueGreenDeployment");

            var request = InstantiateClassGenerator.Execute<CreateBlueGreenDeploymentRequest>();
            var marshaller = new CreateBlueGreenDeploymentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateBlueGreenDeploymentResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateBlueGreenDeployment_DBClusterParameterGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBlueGreenDeployment");

            var request = InstantiateClassGenerator.Execute<CreateBlueGreenDeploymentRequest>();
            var marshaller = new CreateBlueGreenDeploymentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterParameterGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateBlueGreenDeploymentResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateBlueGreenDeployment_DBClusterQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBlueGreenDeployment");

            var request = InstantiateClassGenerator.Execute<CreateBlueGreenDeploymentRequest>();
            var marshaller = new CreateBlueGreenDeploymentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateBlueGreenDeploymentResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateBlueGreenDeployment_DBInstanceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBlueGreenDeployment");

            var request = InstantiateClassGenerator.Execute<CreateBlueGreenDeploymentRequest>();
            var marshaller = new CreateBlueGreenDeploymentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateBlueGreenDeploymentResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateBlueGreenDeployment_DBParameterGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBlueGreenDeployment");

            var request = InstantiateClassGenerator.Execute<CreateBlueGreenDeploymentRequest>();
            var marshaller = new CreateBlueGreenDeploymentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBParameterGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateBlueGreenDeploymentResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateBlueGreenDeployment_InstanceQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBlueGreenDeployment");

            var request = InstantiateClassGenerator.Execute<CreateBlueGreenDeploymentRequest>();
            var marshaller = new CreateBlueGreenDeploymentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InstanceQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateBlueGreenDeploymentResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateBlueGreenDeployment_InvalidDBClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBlueGreenDeployment");

            var request = InstantiateClassGenerator.Execute<CreateBlueGreenDeploymentRequest>();
            var marshaller = new CreateBlueGreenDeploymentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateBlueGreenDeploymentResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateBlueGreenDeployment_InvalidDBInstanceStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBlueGreenDeployment");

            var request = InstantiateClassGenerator.Execute<CreateBlueGreenDeploymentRequest>();
            var marshaller = new CreateBlueGreenDeploymentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBInstanceStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateBlueGreenDeploymentResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateBlueGreenDeployment_SourceClusterNotSupportedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBlueGreenDeployment");

            var request = InstantiateClassGenerator.Execute<CreateBlueGreenDeploymentRequest>();
            var marshaller = new CreateBlueGreenDeploymentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SourceClusterNotSupportedException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateBlueGreenDeploymentResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateBlueGreenDeployment_SourceDatabaseNotSupportedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBlueGreenDeployment");

            var request = InstantiateClassGenerator.Execute<CreateBlueGreenDeploymentRequest>();
            var marshaller = new CreateBlueGreenDeploymentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SourceDatabaseNotSupportedException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateBlueGreenDeploymentResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateCustomDBEngineVersionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCustomDBEngineVersion");

            var request = InstantiateClassGenerator.Execute<CreateCustomDBEngineVersionRequest>();
            var marshaller = new CreateCustomDBEngineVersionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateCustomDBEngineVersionResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateCustomDBEngineVersionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateCustomDBEngineVersion_CreateCustomDBEngineVersionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCustomDBEngineVersion");

            var request = InstantiateClassGenerator.Execute<CreateCustomDBEngineVersionRequest>();
            var marshaller = new CreateCustomDBEngineVersionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CreateCustomDBEngineVersionException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateCustomDBEngineVersionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateCustomDBEngineVersion_CustomDBEngineVersionAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCustomDBEngineVersion");

            var request = InstantiateClassGenerator.Execute<CreateCustomDBEngineVersionRequest>();
            var marshaller = new CreateCustomDBEngineVersionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CustomDBEngineVersionAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateCustomDBEngineVersionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateCustomDBEngineVersion_CustomDBEngineVersionQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCustomDBEngineVersion");

            var request = InstantiateClassGenerator.Execute<CreateCustomDBEngineVersionRequest>();
            var marshaller = new CreateCustomDBEngineVersionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CustomDBEngineVersionQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateCustomDBEngineVersionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateCustomDBEngineVersion_Ec2ImagePropertiesNotSupportedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCustomDBEngineVersion");

            var request = InstantiateClassGenerator.Execute<CreateCustomDBEngineVersionRequest>();
            var marshaller = new CreateCustomDBEngineVersionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("Ec2ImagePropertiesNotSupportedException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateCustomDBEngineVersionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateCustomDBEngineVersion_KMSKeyNotAccessibleExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCustomDBEngineVersion");

            var request = InstantiateClassGenerator.Execute<CreateCustomDBEngineVersionRequest>();
            var marshaller = new CreateCustomDBEngineVersionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("KMSKeyNotAccessibleException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateCustomDBEngineVersionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBClusterMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBCluster");

            var request = InstantiateClassGenerator.Execute<CreateDBClusterRequest>();
            var marshaller = new CreateDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateDBClusterResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateDBClusterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBCluster_DBClusterAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBCluster");

            var request = InstantiateClassGenerator.Execute<CreateDBClusterRequest>();
            var marshaller = new CreateDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBCluster_DBClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBCluster");

            var request = InstantiateClassGenerator.Execute<CreateDBClusterRequest>();
            var marshaller = new CreateDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBCluster_DBClusterParameterGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBCluster");

            var request = InstantiateClassGenerator.Execute<CreateDBClusterRequest>();
            var marshaller = new CreateDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterParameterGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBCluster_DBClusterQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBCluster");

            var request = InstantiateClassGenerator.Execute<CreateDBClusterRequest>();
            var marshaller = new CreateDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBCluster_DBInstanceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBCluster");

            var request = InstantiateClassGenerator.Execute<CreateDBClusterRequest>();
            var marshaller = new CreateDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBCluster_DBSubnetGroupDoesNotCoverEnoughAZsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBCluster");

            var request = InstantiateClassGenerator.Execute<CreateDBClusterRequest>();
            var marshaller = new CreateDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSubnetGroupDoesNotCoverEnoughAZsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBCluster_DBSubnetGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBCluster");

            var request = InstantiateClassGenerator.Execute<CreateDBClusterRequest>();
            var marshaller = new CreateDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSubnetGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBCluster_DomainNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBCluster");

            var request = InstantiateClassGenerator.Execute<CreateDBClusterRequest>();
            var marshaller = new CreateDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DomainNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBCluster_GlobalClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBCluster");

            var request = InstantiateClassGenerator.Execute<CreateDBClusterRequest>();
            var marshaller = new CreateDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("GlobalClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBCluster_InsufficientStorageClusterCapacityExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBCluster");

            var request = InstantiateClassGenerator.Execute<CreateDBClusterRequest>();
            var marshaller = new CreateDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientStorageClusterCapacityException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBCluster_InvalidDBClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBCluster");

            var request = InstantiateClassGenerator.Execute<CreateDBClusterRequest>();
            var marshaller = new CreateDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBCluster_InvalidDBInstanceStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBCluster");

            var request = InstantiateClassGenerator.Execute<CreateDBClusterRequest>();
            var marshaller = new CreateDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBInstanceStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBCluster_InvalidDBSubnetGroupStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBCluster");

            var request = InstantiateClassGenerator.Execute<CreateDBClusterRequest>();
            var marshaller = new CreateDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBSubnetGroupStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBCluster_InvalidGlobalClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBCluster");

            var request = InstantiateClassGenerator.Execute<CreateDBClusterRequest>();
            var marshaller = new CreateDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidGlobalClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBCluster_InvalidSubnetExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBCluster");

            var request = InstantiateClassGenerator.Execute<CreateDBClusterRequest>();
            var marshaller = new CreateDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidSubnetException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBCluster_InvalidVPCNetworkStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBCluster");

            var request = InstantiateClassGenerator.Execute<CreateDBClusterRequest>();
            var marshaller = new CreateDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidVPCNetworkStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBCluster_KMSKeyNotAccessibleExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBCluster");

            var request = InstantiateClassGenerator.Execute<CreateDBClusterRequest>();
            var marshaller = new CreateDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("KMSKeyNotAccessibleException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBCluster_StorageQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBCluster");

            var request = InstantiateClassGenerator.Execute<CreateDBClusterRequest>();
            var marshaller = new CreateDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StorageQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBClusterEndpointMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBClusterEndpoint");

            var request = InstantiateClassGenerator.Execute<CreateDBClusterEndpointRequest>();
            var marshaller = new CreateDBClusterEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateDBClusterEndpointResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateDBClusterEndpointResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBClusterEndpoint_DBClusterEndpointAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBClusterEndpoint");

            var request = InstantiateClassGenerator.Execute<CreateDBClusterEndpointRequest>();
            var marshaller = new CreateDBClusterEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterEndpointAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBClusterEndpointResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBClusterEndpoint_DBClusterEndpointQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBClusterEndpoint");

            var request = InstantiateClassGenerator.Execute<CreateDBClusterEndpointRequest>();
            var marshaller = new CreateDBClusterEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterEndpointQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBClusterEndpointResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBClusterEndpoint_DBClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBClusterEndpoint");

            var request = InstantiateClassGenerator.Execute<CreateDBClusterEndpointRequest>();
            var marshaller = new CreateDBClusterEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBClusterEndpointResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBClusterEndpoint_DBInstanceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBClusterEndpoint");

            var request = InstantiateClassGenerator.Execute<CreateDBClusterEndpointRequest>();
            var marshaller = new CreateDBClusterEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBClusterEndpointResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBClusterEndpoint_InvalidDBClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBClusterEndpoint");

            var request = InstantiateClassGenerator.Execute<CreateDBClusterEndpointRequest>();
            var marshaller = new CreateDBClusterEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBClusterEndpointResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBClusterEndpoint_InvalidDBInstanceStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBClusterEndpoint");

            var request = InstantiateClassGenerator.Execute<CreateDBClusterEndpointRequest>();
            var marshaller = new CreateDBClusterEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBInstanceStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBClusterEndpointResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBClusterParameterGroupMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<CreateDBClusterParameterGroupRequest>();
            var marshaller = new CreateDBClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateDBClusterParameterGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateDBClusterParameterGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBClusterParameterGroup_DBParameterGroupAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<CreateDBClusterParameterGroupRequest>();
            var marshaller = new CreateDBClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBParameterGroupAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBClusterParameterGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBClusterParameterGroup_DBParameterGroupQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<CreateDBClusterParameterGroupRequest>();
            var marshaller = new CreateDBClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBParameterGroupQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBClusterParameterGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBClusterSnapshotMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<CreateDBClusterSnapshotRequest>();
            var marshaller = new CreateDBClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateDBClusterSnapshotResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateDBClusterSnapshotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBClusterSnapshot_DBClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<CreateDBClusterSnapshotRequest>();
            var marshaller = new CreateDBClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBClusterSnapshot_DBClusterSnapshotAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<CreateDBClusterSnapshotRequest>();
            var marshaller = new CreateDBClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterSnapshotAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBClusterSnapshot_InvalidDBClusterSnapshotStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<CreateDBClusterSnapshotRequest>();
            var marshaller = new CreateDBClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterSnapshotStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBClusterSnapshot_InvalidDBClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<CreateDBClusterSnapshotRequest>();
            var marshaller = new CreateDBClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBClusterSnapshot_SnapshotQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<CreateDBClusterSnapshotRequest>();
            var marshaller = new CreateDBClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SnapshotQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstanceMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstance");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceRequest>();
            var marshaller = new CreateDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateDBInstanceResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateDBInstanceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstance_AuthorizationNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstance");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceRequest>();
            var marshaller = new CreateDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AuthorizationNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstance_BackupPolicyNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstance");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceRequest>();
            var marshaller = new CreateDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BackupPolicyNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstance_CertificateNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstance");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceRequest>();
            var marshaller = new CreateDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CertificateNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstance_DBClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstance");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceRequest>();
            var marshaller = new CreateDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstance_DBInstanceAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstance");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceRequest>();
            var marshaller = new CreateDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstance_DBParameterGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstance");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceRequest>();
            var marshaller = new CreateDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBParameterGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstance_DBSecurityGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstance");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceRequest>();
            var marshaller = new CreateDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSecurityGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstance_DBSubnetGroupDoesNotCoverEnoughAZsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstance");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceRequest>();
            var marshaller = new CreateDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSubnetGroupDoesNotCoverEnoughAZsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstance_DBSubnetGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstance");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceRequest>();
            var marshaller = new CreateDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSubnetGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstance_DomainNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstance");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceRequest>();
            var marshaller = new CreateDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DomainNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstance_InstanceQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstance");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceRequest>();
            var marshaller = new CreateDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InstanceQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstance_InsufficientDBInstanceCapacityExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstance");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceRequest>();
            var marshaller = new CreateDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientDBInstanceCapacityException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstance_InvalidDBClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstance");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceRequest>();
            var marshaller = new CreateDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstance_InvalidSubnetExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstance");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceRequest>();
            var marshaller = new CreateDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidSubnetException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstance_InvalidVPCNetworkStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstance");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceRequest>();
            var marshaller = new CreateDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidVPCNetworkStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstance_KMSKeyNotAccessibleExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstance");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceRequest>();
            var marshaller = new CreateDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("KMSKeyNotAccessibleException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstance_NetworkTypeNotSupportedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstance");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceRequest>();
            var marshaller = new CreateDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("NetworkTypeNotSupportedException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstance_OptionGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstance");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceRequest>();
            var marshaller = new CreateDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OptionGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstance_ProvisionedIopsNotAvailableInAZExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstance");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceRequest>();
            var marshaller = new CreateDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ProvisionedIopsNotAvailableInAZException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstance_StorageQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstance");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceRequest>();
            var marshaller = new CreateDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StorageQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstance_StorageTypeNotSupportedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstance");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceRequest>();
            var marshaller = new CreateDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StorageTypeNotSupportedException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstanceReadReplicaMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstanceReadReplica");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceReadReplicaRequest>();
            var marshaller = new CreateDBInstanceReadReplicaRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateDBInstanceReadReplicaResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateDBInstanceReadReplicaResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstanceReadReplica_DBInstanceAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstanceReadReplica");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceReadReplicaRequest>();
            var marshaller = new CreateDBInstanceReadReplicaRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceReadReplicaResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstanceReadReplica_DBInstanceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstanceReadReplica");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceReadReplicaRequest>();
            var marshaller = new CreateDBInstanceReadReplicaRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceReadReplicaResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstanceReadReplica_DBParameterGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstanceReadReplica");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceReadReplicaRequest>();
            var marshaller = new CreateDBInstanceReadReplicaRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBParameterGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceReadReplicaResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstanceReadReplica_DBSecurityGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstanceReadReplica");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceReadReplicaRequest>();
            var marshaller = new CreateDBInstanceReadReplicaRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSecurityGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceReadReplicaResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstanceReadReplica_DBSubnetGroupDoesNotCoverEnoughAZsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstanceReadReplica");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceReadReplicaRequest>();
            var marshaller = new CreateDBInstanceReadReplicaRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSubnetGroupDoesNotCoverEnoughAZsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceReadReplicaResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstanceReadReplica_DBSubnetGroupNotAllowedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstanceReadReplica");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceReadReplicaRequest>();
            var marshaller = new CreateDBInstanceReadReplicaRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSubnetGroupNotAllowedException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceReadReplicaResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstanceReadReplica_DBSubnetGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstanceReadReplica");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceReadReplicaRequest>();
            var marshaller = new CreateDBInstanceReadReplicaRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSubnetGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceReadReplicaResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstanceReadReplica_DomainNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstanceReadReplica");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceReadReplicaRequest>();
            var marshaller = new CreateDBInstanceReadReplicaRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DomainNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceReadReplicaResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstanceReadReplica_InstanceQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstanceReadReplica");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceReadReplicaRequest>();
            var marshaller = new CreateDBInstanceReadReplicaRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InstanceQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceReadReplicaResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstanceReadReplica_InsufficientDBInstanceCapacityExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstanceReadReplica");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceReadReplicaRequest>();
            var marshaller = new CreateDBInstanceReadReplicaRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientDBInstanceCapacityException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceReadReplicaResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstanceReadReplica_InvalidDBInstanceStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstanceReadReplica");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceReadReplicaRequest>();
            var marshaller = new CreateDBInstanceReadReplicaRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBInstanceStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceReadReplicaResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstanceReadReplica_InvalidDBSubnetGroupExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstanceReadReplica");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceReadReplicaRequest>();
            var marshaller = new CreateDBInstanceReadReplicaRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBSubnetGroupException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceReadReplicaResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstanceReadReplica_InvalidSubnetExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstanceReadReplica");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceReadReplicaRequest>();
            var marshaller = new CreateDBInstanceReadReplicaRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidSubnetException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceReadReplicaResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstanceReadReplica_InvalidVPCNetworkStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstanceReadReplica");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceReadReplicaRequest>();
            var marshaller = new CreateDBInstanceReadReplicaRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidVPCNetworkStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceReadReplicaResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstanceReadReplica_KMSKeyNotAccessibleExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstanceReadReplica");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceReadReplicaRequest>();
            var marshaller = new CreateDBInstanceReadReplicaRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("KMSKeyNotAccessibleException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceReadReplicaResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstanceReadReplica_NetworkTypeNotSupportedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstanceReadReplica");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceReadReplicaRequest>();
            var marshaller = new CreateDBInstanceReadReplicaRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("NetworkTypeNotSupportedException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceReadReplicaResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstanceReadReplica_OptionGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstanceReadReplica");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceReadReplicaRequest>();
            var marshaller = new CreateDBInstanceReadReplicaRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OptionGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceReadReplicaResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstanceReadReplica_ProvisionedIopsNotAvailableInAZExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstanceReadReplica");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceReadReplicaRequest>();
            var marshaller = new CreateDBInstanceReadReplicaRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ProvisionedIopsNotAvailableInAZException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceReadReplicaResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstanceReadReplica_StorageQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstanceReadReplica");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceReadReplicaRequest>();
            var marshaller = new CreateDBInstanceReadReplicaRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StorageQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceReadReplicaResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBInstanceReadReplica_StorageTypeNotSupportedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstanceReadReplica");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceReadReplicaRequest>();
            var marshaller = new CreateDBInstanceReadReplicaRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StorageTypeNotSupportedException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBInstanceReadReplicaResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBParameterGroupMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBParameterGroup");

            var request = InstantiateClassGenerator.Execute<CreateDBParameterGroupRequest>();
            var marshaller = new CreateDBParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateDBParameterGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateDBParameterGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBParameterGroup_DBParameterGroupAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBParameterGroup");

            var request = InstantiateClassGenerator.Execute<CreateDBParameterGroupRequest>();
            var marshaller = new CreateDBParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBParameterGroupAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBParameterGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBParameterGroup_DBParameterGroupQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBParameterGroup");

            var request = InstantiateClassGenerator.Execute<CreateDBParameterGroupRequest>();
            var marshaller = new CreateDBParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBParameterGroupQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBParameterGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBProxyMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBProxy");

            var request = InstantiateClassGenerator.Execute<CreateDBProxyRequest>();
            var marshaller = new CreateDBProxyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateDBProxyResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateDBProxyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBProxy_DBProxyAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBProxy");

            var request = InstantiateClassGenerator.Execute<CreateDBProxyRequest>();
            var marshaller = new CreateDBProxyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBProxyAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBProxyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBProxy_DBProxyQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBProxy");

            var request = InstantiateClassGenerator.Execute<CreateDBProxyRequest>();
            var marshaller = new CreateDBProxyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBProxyQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBProxyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBProxy_InvalidSubnetExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBProxy");

            var request = InstantiateClassGenerator.Execute<CreateDBProxyRequest>();
            var marshaller = new CreateDBProxyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidSubnetException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBProxyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBProxyEndpointMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBProxyEndpoint");

            var request = InstantiateClassGenerator.Execute<CreateDBProxyEndpointRequest>();
            var marshaller = new CreateDBProxyEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateDBProxyEndpointResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateDBProxyEndpointResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBProxyEndpoint_DBProxyEndpointAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBProxyEndpoint");

            var request = InstantiateClassGenerator.Execute<CreateDBProxyEndpointRequest>();
            var marshaller = new CreateDBProxyEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBProxyEndpointAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBProxyEndpointResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBProxyEndpoint_DBProxyEndpointQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBProxyEndpoint");

            var request = InstantiateClassGenerator.Execute<CreateDBProxyEndpointRequest>();
            var marshaller = new CreateDBProxyEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBProxyEndpointQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBProxyEndpointResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBProxyEndpoint_DBProxyNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBProxyEndpoint");

            var request = InstantiateClassGenerator.Execute<CreateDBProxyEndpointRequest>();
            var marshaller = new CreateDBProxyEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBProxyNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBProxyEndpointResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBProxyEndpoint_InvalidDBProxyStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBProxyEndpoint");

            var request = InstantiateClassGenerator.Execute<CreateDBProxyEndpointRequest>();
            var marshaller = new CreateDBProxyEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBProxyStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBProxyEndpointResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBProxyEndpoint_InvalidSubnetExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBProxyEndpoint");

            var request = InstantiateClassGenerator.Execute<CreateDBProxyEndpointRequest>();
            var marshaller = new CreateDBProxyEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidSubnetException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBProxyEndpointResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBSecurityGroupMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBSecurityGroup");

            var request = InstantiateClassGenerator.Execute<CreateDBSecurityGroupRequest>();
            var marshaller = new CreateDBSecurityGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateDBSecurityGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateDBSecurityGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBSecurityGroup_DBSecurityGroupAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBSecurityGroup");

            var request = InstantiateClassGenerator.Execute<CreateDBSecurityGroupRequest>();
            var marshaller = new CreateDBSecurityGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSecurityGroupAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBSecurityGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBSecurityGroup_DBSecurityGroupNotSupportedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBSecurityGroup");

            var request = InstantiateClassGenerator.Execute<CreateDBSecurityGroupRequest>();
            var marshaller = new CreateDBSecurityGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSecurityGroupNotSupportedException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBSecurityGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBSecurityGroup_DBSecurityGroupQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBSecurityGroup");

            var request = InstantiateClassGenerator.Execute<CreateDBSecurityGroupRequest>();
            var marshaller = new CreateDBSecurityGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSecurityGroupQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBSecurityGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBSnapshotMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBSnapshot");

            var request = InstantiateClassGenerator.Execute<CreateDBSnapshotRequest>();
            var marshaller = new CreateDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateDBSnapshotResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateDBSnapshotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBSnapshot_DBInstanceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBSnapshot");

            var request = InstantiateClassGenerator.Execute<CreateDBSnapshotRequest>();
            var marshaller = new CreateDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBSnapshot_DBSnapshotAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBSnapshot");

            var request = InstantiateClassGenerator.Execute<CreateDBSnapshotRequest>();
            var marshaller = new CreateDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSnapshotAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBSnapshot_InvalidDBInstanceStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBSnapshot");

            var request = InstantiateClassGenerator.Execute<CreateDBSnapshotRequest>();
            var marshaller = new CreateDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBInstanceStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBSnapshot_SnapshotQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBSnapshot");

            var request = InstantiateClassGenerator.Execute<CreateDBSnapshotRequest>();
            var marshaller = new CreateDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SnapshotQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBSubnetGroupMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBSubnetGroup");

            var request = InstantiateClassGenerator.Execute<CreateDBSubnetGroupRequest>();
            var marshaller = new CreateDBSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateDBSubnetGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateDBSubnetGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBSubnetGroup_DBSubnetGroupAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBSubnetGroup");

            var request = InstantiateClassGenerator.Execute<CreateDBSubnetGroupRequest>();
            var marshaller = new CreateDBSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSubnetGroupAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBSubnetGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBSubnetGroup_DBSubnetGroupDoesNotCoverEnoughAZsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBSubnetGroup");

            var request = InstantiateClassGenerator.Execute<CreateDBSubnetGroupRequest>();
            var marshaller = new CreateDBSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSubnetGroupDoesNotCoverEnoughAZsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBSubnetGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBSubnetGroup_DBSubnetGroupQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBSubnetGroup");

            var request = InstantiateClassGenerator.Execute<CreateDBSubnetGroupRequest>();
            var marshaller = new CreateDBSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSubnetGroupQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBSubnetGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBSubnetGroup_DBSubnetQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBSubnetGroup");

            var request = InstantiateClassGenerator.Execute<CreateDBSubnetGroupRequest>();
            var marshaller = new CreateDBSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSubnetQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBSubnetGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBSubnetGroup_InvalidSubnetExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBSubnetGroup");

            var request = InstantiateClassGenerator.Execute<CreateDBSubnetGroupRequest>();
            var marshaller = new CreateDBSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidSubnetException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateDBSubnetGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateEventSubscriptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateEventSubscription");

            var request = InstantiateClassGenerator.Execute<CreateEventSubscriptionRequest>();
            var marshaller = new CreateEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateEventSubscriptionResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateEventSubscriptionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateEventSubscription_EventSubscriptionQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateEventSubscription");

            var request = InstantiateClassGenerator.Execute<CreateEventSubscriptionRequest>();
            var marshaller = new CreateEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("EventSubscriptionQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateEventSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateEventSubscription_SNSInvalidTopicExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateEventSubscription");

            var request = InstantiateClassGenerator.Execute<CreateEventSubscriptionRequest>();
            var marshaller = new CreateEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SNSInvalidTopicException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateEventSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateEventSubscription_SNSNoAuthorizationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateEventSubscription");

            var request = InstantiateClassGenerator.Execute<CreateEventSubscriptionRequest>();
            var marshaller = new CreateEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SNSNoAuthorizationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateEventSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateEventSubscription_SNSTopicArnNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateEventSubscription");

            var request = InstantiateClassGenerator.Execute<CreateEventSubscriptionRequest>();
            var marshaller = new CreateEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SNSTopicArnNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateEventSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateEventSubscription_SourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateEventSubscription");

            var request = InstantiateClassGenerator.Execute<CreateEventSubscriptionRequest>();
            var marshaller = new CreateEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateEventSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateEventSubscription_SubscriptionAlreadyExistExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateEventSubscription");

            var request = InstantiateClassGenerator.Execute<CreateEventSubscriptionRequest>();
            var marshaller = new CreateEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SubscriptionAlreadyExistException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateEventSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateEventSubscription_SubscriptionCategoryNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateEventSubscription");

            var request = InstantiateClassGenerator.Execute<CreateEventSubscriptionRequest>();
            var marshaller = new CreateEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SubscriptionCategoryNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateEventSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateGlobalClusterMarshallTest()
        {
            var operation = service_model.FindOperation("CreateGlobalCluster");

            var request = InstantiateClassGenerator.Execute<CreateGlobalClusterRequest>();
            var marshaller = new CreateGlobalClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateGlobalClusterResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateGlobalClusterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateGlobalCluster_DBClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateGlobalCluster");

            var request = InstantiateClassGenerator.Execute<CreateGlobalClusterRequest>();
            var marshaller = new CreateGlobalClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateGlobalClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateGlobalCluster_GlobalClusterAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateGlobalCluster");

            var request = InstantiateClassGenerator.Execute<CreateGlobalClusterRequest>();
            var marshaller = new CreateGlobalClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("GlobalClusterAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateGlobalClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateGlobalCluster_GlobalClusterQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateGlobalCluster");

            var request = InstantiateClassGenerator.Execute<CreateGlobalClusterRequest>();
            var marshaller = new CreateGlobalClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("GlobalClusterQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateGlobalClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateGlobalCluster_InvalidDBClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateGlobalCluster");

            var request = InstantiateClassGenerator.Execute<CreateGlobalClusterRequest>();
            var marshaller = new CreateGlobalClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateGlobalClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateOptionGroupMarshallTest()
        {
            var operation = service_model.FindOperation("CreateOptionGroup");

            var request = InstantiateClassGenerator.Execute<CreateOptionGroupRequest>();
            var marshaller = new CreateOptionGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateOptionGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateOptionGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateOptionGroup_OptionGroupAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateOptionGroup");

            var request = InstantiateClassGenerator.Execute<CreateOptionGroupRequest>();
            var marshaller = new CreateOptionGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OptionGroupAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateOptionGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateOptionGroup_OptionGroupQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateOptionGroup");

            var request = InstantiateClassGenerator.Execute<CreateOptionGroupRequest>();
            var marshaller = new CreateOptionGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OptionGroupQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateOptionGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteBlueGreenDeploymentMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteBlueGreenDeployment");

            var request = InstantiateClassGenerator.Execute<DeleteBlueGreenDeploymentRequest>();
            var marshaller = new DeleteBlueGreenDeploymentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteBlueGreenDeploymentResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteBlueGreenDeploymentResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteBlueGreenDeployment_BlueGreenDeploymentNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteBlueGreenDeployment");

            var request = InstantiateClassGenerator.Execute<DeleteBlueGreenDeploymentRequest>();
            var marshaller = new DeleteBlueGreenDeploymentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BlueGreenDeploymentNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteBlueGreenDeploymentResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteBlueGreenDeployment_InvalidBlueGreenDeploymentStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteBlueGreenDeployment");

            var request = InstantiateClassGenerator.Execute<DeleteBlueGreenDeploymentRequest>();
            var marshaller = new DeleteBlueGreenDeploymentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidBlueGreenDeploymentStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteBlueGreenDeploymentResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteCustomDBEngineVersionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCustomDBEngineVersion");

            var request = InstantiateClassGenerator.Execute<DeleteCustomDBEngineVersionRequest>();
            var marshaller = new DeleteCustomDBEngineVersionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteCustomDBEngineVersionResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteCustomDBEngineVersionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteCustomDBEngineVersion_CustomDBEngineVersionNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCustomDBEngineVersion");

            var request = InstantiateClassGenerator.Execute<DeleteCustomDBEngineVersionRequest>();
            var marshaller = new DeleteCustomDBEngineVersionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CustomDBEngineVersionNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteCustomDBEngineVersionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteCustomDBEngineVersion_InvalidCustomDBEngineVersionStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCustomDBEngineVersion");

            var request = InstantiateClassGenerator.Execute<DeleteCustomDBEngineVersionRequest>();
            var marshaller = new DeleteCustomDBEngineVersionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidCustomDBEngineVersionStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteCustomDBEngineVersionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBClusterMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBCluster");

            var request = InstantiateClassGenerator.Execute<DeleteDBClusterRequest>();
            var marshaller = new DeleteDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteDBClusterResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteDBClusterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBCluster_DBClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBCluster");

            var request = InstantiateClassGenerator.Execute<DeleteDBClusterRequest>();
            var marshaller = new DeleteDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBCluster_DBClusterSnapshotAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBCluster");

            var request = InstantiateClassGenerator.Execute<DeleteDBClusterRequest>();
            var marshaller = new DeleteDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterSnapshotAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBCluster_InvalidDBClusterSnapshotStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBCluster");

            var request = InstantiateClassGenerator.Execute<DeleteDBClusterRequest>();
            var marshaller = new DeleteDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterSnapshotStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBCluster_InvalidDBClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBCluster");

            var request = InstantiateClassGenerator.Execute<DeleteDBClusterRequest>();
            var marshaller = new DeleteDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBCluster_SnapshotQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBCluster");

            var request = InstantiateClassGenerator.Execute<DeleteDBClusterRequest>();
            var marshaller = new DeleteDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SnapshotQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBClusterEndpointMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBClusterEndpoint");

            var request = InstantiateClassGenerator.Execute<DeleteDBClusterEndpointRequest>();
            var marshaller = new DeleteDBClusterEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteDBClusterEndpointResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteDBClusterEndpointResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBClusterEndpoint_DBClusterEndpointNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBClusterEndpoint");

            var request = InstantiateClassGenerator.Execute<DeleteDBClusterEndpointRequest>();
            var marshaller = new DeleteDBClusterEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterEndpointNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteDBClusterEndpointResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBClusterEndpoint_InvalidDBClusterEndpointStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBClusterEndpoint");

            var request = InstantiateClassGenerator.Execute<DeleteDBClusterEndpointRequest>();
            var marshaller = new DeleteDBClusterEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterEndpointStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteDBClusterEndpointResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBClusterEndpoint_InvalidDBClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBClusterEndpoint");

            var request = InstantiateClassGenerator.Execute<DeleteDBClusterEndpointRequest>();
            var marshaller = new DeleteDBClusterEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteDBClusterEndpointResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBClusterParameterGroupMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<DeleteDBClusterParameterGroupRequest>();
            var marshaller = new DeleteDBClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBClusterParameterGroup_DBParameterGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<DeleteDBClusterParameterGroupRequest>();
            var marshaller = new DeleteDBClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBParameterGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteDBClusterParameterGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBClusterParameterGroup_InvalidDBParameterGroupStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<DeleteDBClusterParameterGroupRequest>();
            var marshaller = new DeleteDBClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBParameterGroupStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteDBClusterParameterGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBClusterSnapshotMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<DeleteDBClusterSnapshotRequest>();
            var marshaller = new DeleteDBClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteDBClusterSnapshotResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteDBClusterSnapshotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBClusterSnapshot_DBClusterSnapshotNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<DeleteDBClusterSnapshotRequest>();
            var marshaller = new DeleteDBClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterSnapshotNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteDBClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBClusterSnapshot_InvalidDBClusterSnapshotStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<DeleteDBClusterSnapshotRequest>();
            var marshaller = new DeleteDBClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterSnapshotStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteDBClusterSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBInstanceMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBInstance");

            var request = InstantiateClassGenerator.Execute<DeleteDBInstanceRequest>();
            var marshaller = new DeleteDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteDBInstanceResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteDBInstanceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBInstance_DBInstanceAutomatedBackupQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBInstance");

            var request = InstantiateClassGenerator.Execute<DeleteDBInstanceRequest>();
            var marshaller = new DeleteDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceAutomatedBackupQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBInstance_DBInstanceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBInstance");

            var request = InstantiateClassGenerator.Execute<DeleteDBInstanceRequest>();
            var marshaller = new DeleteDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBInstance_DBSnapshotAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBInstance");

            var request = InstantiateClassGenerator.Execute<DeleteDBInstanceRequest>();
            var marshaller = new DeleteDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSnapshotAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBInstance_InvalidDBClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBInstance");

            var request = InstantiateClassGenerator.Execute<DeleteDBInstanceRequest>();
            var marshaller = new DeleteDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBInstance_InvalidDBInstanceStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBInstance");

            var request = InstantiateClassGenerator.Execute<DeleteDBInstanceRequest>();
            var marshaller = new DeleteDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBInstanceStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBInstance_SnapshotQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBInstance");

            var request = InstantiateClassGenerator.Execute<DeleteDBInstanceRequest>();
            var marshaller = new DeleteDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SnapshotQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBInstanceAutomatedBackupMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBInstanceAutomatedBackup");

            var request = InstantiateClassGenerator.Execute<DeleteDBInstanceAutomatedBackupRequest>();
            var marshaller = new DeleteDBInstanceAutomatedBackupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteDBInstanceAutomatedBackupResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteDBInstanceAutomatedBackupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBInstanceAutomatedBackup_DBInstanceAutomatedBackupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBInstanceAutomatedBackup");

            var request = InstantiateClassGenerator.Execute<DeleteDBInstanceAutomatedBackupRequest>();
            var marshaller = new DeleteDBInstanceAutomatedBackupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceAutomatedBackupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteDBInstanceAutomatedBackupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBInstanceAutomatedBackup_InvalidDBInstanceAutomatedBackupStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBInstanceAutomatedBackup");

            var request = InstantiateClassGenerator.Execute<DeleteDBInstanceAutomatedBackupRequest>();
            var marshaller = new DeleteDBInstanceAutomatedBackupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBInstanceAutomatedBackupStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteDBInstanceAutomatedBackupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBParameterGroupMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBParameterGroup");

            var request = InstantiateClassGenerator.Execute<DeleteDBParameterGroupRequest>();
            var marshaller = new DeleteDBParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBParameterGroup_DBParameterGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBParameterGroup");

            var request = InstantiateClassGenerator.Execute<DeleteDBParameterGroupRequest>();
            var marshaller = new DeleteDBParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBParameterGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteDBParameterGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBParameterGroup_InvalidDBParameterGroupStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBParameterGroup");

            var request = InstantiateClassGenerator.Execute<DeleteDBParameterGroupRequest>();
            var marshaller = new DeleteDBParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBParameterGroupStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteDBParameterGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBProxyMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBProxy");

            var request = InstantiateClassGenerator.Execute<DeleteDBProxyRequest>();
            var marshaller = new DeleteDBProxyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteDBProxyResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteDBProxyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBProxy_DBProxyNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBProxy");

            var request = InstantiateClassGenerator.Execute<DeleteDBProxyRequest>();
            var marshaller = new DeleteDBProxyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBProxyNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteDBProxyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBProxy_InvalidDBProxyStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBProxy");

            var request = InstantiateClassGenerator.Execute<DeleteDBProxyRequest>();
            var marshaller = new DeleteDBProxyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBProxyStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteDBProxyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBProxyEndpointMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBProxyEndpoint");

            var request = InstantiateClassGenerator.Execute<DeleteDBProxyEndpointRequest>();
            var marshaller = new DeleteDBProxyEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteDBProxyEndpointResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteDBProxyEndpointResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBProxyEndpoint_DBProxyEndpointNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBProxyEndpoint");

            var request = InstantiateClassGenerator.Execute<DeleteDBProxyEndpointRequest>();
            var marshaller = new DeleteDBProxyEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBProxyEndpointNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteDBProxyEndpointResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBProxyEndpoint_InvalidDBProxyEndpointStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBProxyEndpoint");

            var request = InstantiateClassGenerator.Execute<DeleteDBProxyEndpointRequest>();
            var marshaller = new DeleteDBProxyEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBProxyEndpointStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteDBProxyEndpointResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBSecurityGroupMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBSecurityGroup");

            var request = InstantiateClassGenerator.Execute<DeleteDBSecurityGroupRequest>();
            var marshaller = new DeleteDBSecurityGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBSecurityGroup_DBSecurityGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBSecurityGroup");

            var request = InstantiateClassGenerator.Execute<DeleteDBSecurityGroupRequest>();
            var marshaller = new DeleteDBSecurityGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSecurityGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteDBSecurityGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBSecurityGroup_InvalidDBSecurityGroupStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBSecurityGroup");

            var request = InstantiateClassGenerator.Execute<DeleteDBSecurityGroupRequest>();
            var marshaller = new DeleteDBSecurityGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBSecurityGroupStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteDBSecurityGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBSnapshotMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBSnapshot");

            var request = InstantiateClassGenerator.Execute<DeleteDBSnapshotRequest>();
            var marshaller = new DeleteDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteDBSnapshotResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteDBSnapshotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBSnapshot_DBSnapshotNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBSnapshot");

            var request = InstantiateClassGenerator.Execute<DeleteDBSnapshotRequest>();
            var marshaller = new DeleteDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSnapshotNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteDBSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBSnapshot_InvalidDBSnapshotStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBSnapshot");

            var request = InstantiateClassGenerator.Execute<DeleteDBSnapshotRequest>();
            var marshaller = new DeleteDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBSnapshotStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteDBSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBSubnetGroupMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBSubnetGroup");

            var request = InstantiateClassGenerator.Execute<DeleteDBSubnetGroupRequest>();
            var marshaller = new DeleteDBSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBSubnetGroup_DBSubnetGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBSubnetGroup");

            var request = InstantiateClassGenerator.Execute<DeleteDBSubnetGroupRequest>();
            var marshaller = new DeleteDBSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSubnetGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteDBSubnetGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBSubnetGroup_InvalidDBSubnetGroupStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBSubnetGroup");

            var request = InstantiateClassGenerator.Execute<DeleteDBSubnetGroupRequest>();
            var marshaller = new DeleteDBSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBSubnetGroupStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteDBSubnetGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBSubnetGroup_InvalidDBSubnetStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBSubnetGroup");

            var request = InstantiateClassGenerator.Execute<DeleteDBSubnetGroupRequest>();
            var marshaller = new DeleteDBSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBSubnetStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteDBSubnetGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteEventSubscriptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteEventSubscription");

            var request = InstantiateClassGenerator.Execute<DeleteEventSubscriptionRequest>();
            var marshaller = new DeleteEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteEventSubscriptionResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteEventSubscriptionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteEventSubscription_InvalidEventSubscriptionStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteEventSubscription");

            var request = InstantiateClassGenerator.Execute<DeleteEventSubscriptionRequest>();
            var marshaller = new DeleteEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidEventSubscriptionStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteEventSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteEventSubscription_SubscriptionNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteEventSubscription");

            var request = InstantiateClassGenerator.Execute<DeleteEventSubscriptionRequest>();
            var marshaller = new DeleteEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SubscriptionNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteEventSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteGlobalClusterMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteGlobalCluster");

            var request = InstantiateClassGenerator.Execute<DeleteGlobalClusterRequest>();
            var marshaller = new DeleteGlobalClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteGlobalClusterResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteGlobalClusterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteGlobalCluster_GlobalClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteGlobalCluster");

            var request = InstantiateClassGenerator.Execute<DeleteGlobalClusterRequest>();
            var marshaller = new DeleteGlobalClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("GlobalClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteGlobalClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteGlobalCluster_InvalidGlobalClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteGlobalCluster");

            var request = InstantiateClassGenerator.Execute<DeleteGlobalClusterRequest>();
            var marshaller = new DeleteGlobalClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidGlobalClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteGlobalClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteOptionGroupMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteOptionGroup");

            var request = InstantiateClassGenerator.Execute<DeleteOptionGroupRequest>();
            var marshaller = new DeleteOptionGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteOptionGroup_InvalidOptionGroupStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteOptionGroup");

            var request = InstantiateClassGenerator.Execute<DeleteOptionGroupRequest>();
            var marshaller = new DeleteOptionGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidOptionGroupStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteOptionGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteOptionGroup_OptionGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteOptionGroup");

            var request = InstantiateClassGenerator.Execute<DeleteOptionGroupRequest>();
            var marshaller = new DeleteOptionGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OptionGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteOptionGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeregisterDBProxyTargetsMarshallTest()
        {
            var operation = service_model.FindOperation("DeregisterDBProxyTargets");

            var request = InstantiateClassGenerator.Execute<DeregisterDBProxyTargetsRequest>();
            var marshaller = new DeregisterDBProxyTargetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeregisterDBProxyTargetsResponseUnmarshaller.Instance.Unmarshall(context)
                as DeregisterDBProxyTargetsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeregisterDBProxyTargets_DBProxyNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeregisterDBProxyTargets");

            var request = InstantiateClassGenerator.Execute<DeregisterDBProxyTargetsRequest>();
            var marshaller = new DeregisterDBProxyTargetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBProxyNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeregisterDBProxyTargetsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeregisterDBProxyTargets_DBProxyTargetGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeregisterDBProxyTargets");

            var request = InstantiateClassGenerator.Execute<DeregisterDBProxyTargetsRequest>();
            var marshaller = new DeregisterDBProxyTargetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBProxyTargetGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeregisterDBProxyTargetsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeregisterDBProxyTargets_DBProxyTargetNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeregisterDBProxyTargets");

            var request = InstantiateClassGenerator.Execute<DeregisterDBProxyTargetsRequest>();
            var marshaller = new DeregisterDBProxyTargetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBProxyTargetNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeregisterDBProxyTargetsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeregisterDBProxyTargets_InvalidDBProxyStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeregisterDBProxyTargets");

            var request = InstantiateClassGenerator.Execute<DeregisterDBProxyTargetsRequest>();
            var marshaller = new DeregisterDBProxyTargetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBProxyStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeregisterDBProxyTargetsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeAccountAttributesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAccountAttributes");

            var request = InstantiateClassGenerator.Execute<DescribeAccountAttributesRequest>();
            var marshaller = new DescribeAccountAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeAccountAttributesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeAccountAttributesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeBlueGreenDeploymentsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeBlueGreenDeployments");

            var request = InstantiateClassGenerator.Execute<DescribeBlueGreenDeploymentsRequest>();
            var marshaller = new DescribeBlueGreenDeploymentsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeBlueGreenDeploymentsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeBlueGreenDeploymentsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeBlueGreenDeployments_BlueGreenDeploymentNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeBlueGreenDeployments");

            var request = InstantiateClassGenerator.Execute<DescribeBlueGreenDeploymentsRequest>();
            var marshaller = new DescribeBlueGreenDeploymentsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BlueGreenDeploymentNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeBlueGreenDeploymentsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeCertificatesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeCertificates");

            var request = InstantiateClassGenerator.Execute<DescribeCertificatesRequest>();
            var marshaller = new DescribeCertificatesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeCertificatesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeCertificatesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeCertificates_CertificateNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeCertificates");

            var request = InstantiateClassGenerator.Execute<DescribeCertificatesRequest>();
            var marshaller = new DescribeCertificatesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CertificateNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeCertificatesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBClusterBacktracksMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBClusterBacktracks");

            var request = InstantiateClassGenerator.Execute<DescribeDBClusterBacktracksRequest>();
            var marshaller = new DescribeDBClusterBacktracksRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDBClusterBacktracksResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDBClusterBacktracksResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBClusterBacktracks_DBClusterBacktrackNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBClusterBacktracks");

            var request = InstantiateClassGenerator.Execute<DescribeDBClusterBacktracksRequest>();
            var marshaller = new DescribeDBClusterBacktracksRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterBacktrackNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeDBClusterBacktracksResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBClusterBacktracks_DBClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBClusterBacktracks");

            var request = InstantiateClassGenerator.Execute<DescribeDBClusterBacktracksRequest>();
            var marshaller = new DescribeDBClusterBacktracksRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeDBClusterBacktracksResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBClusterEndpointsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBClusterEndpoints");

            var request = InstantiateClassGenerator.Execute<DescribeDBClusterEndpointsRequest>();
            var marshaller = new DescribeDBClusterEndpointsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDBClusterEndpointsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDBClusterEndpointsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBClusterEndpoints_DBClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBClusterEndpoints");

            var request = InstantiateClassGenerator.Execute<DescribeDBClusterEndpointsRequest>();
            var marshaller = new DescribeDBClusterEndpointsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeDBClusterEndpointsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBClusterParameterGroupsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBClusterParameterGroups");

            var request = InstantiateClassGenerator.Execute<DescribeDBClusterParameterGroupsRequest>();
            var marshaller = new DescribeDBClusterParameterGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDBClusterParameterGroupsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDBClusterParameterGroupsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBClusterParameterGroups_DBParameterGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBClusterParameterGroups");

            var request = InstantiateClassGenerator.Execute<DescribeDBClusterParameterGroupsRequest>();
            var marshaller = new DescribeDBClusterParameterGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBParameterGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeDBClusterParameterGroupsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBClusterParametersMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBClusterParameters");

            var request = InstantiateClassGenerator.Execute<DescribeDBClusterParametersRequest>();
            var marshaller = new DescribeDBClusterParametersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDBClusterParametersResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDBClusterParametersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBClusterParameters_DBParameterGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBClusterParameters");

            var request = InstantiateClassGenerator.Execute<DescribeDBClusterParametersRequest>();
            var marshaller = new DescribeDBClusterParametersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBParameterGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeDBClusterParametersResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBClustersMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBClusters");

            var request = InstantiateClassGenerator.Execute<DescribeDBClustersRequest>();
            var marshaller = new DescribeDBClustersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDBClustersResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDBClustersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBClusters_DBClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBClusters");

            var request = InstantiateClassGenerator.Execute<DescribeDBClustersRequest>();
            var marshaller = new DescribeDBClustersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeDBClustersResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBClusterSnapshotAttributesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBClusterSnapshotAttributes");

            var request = InstantiateClassGenerator.Execute<DescribeDBClusterSnapshotAttributesRequest>();
            var marshaller = new DescribeDBClusterSnapshotAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDBClusterSnapshotAttributesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDBClusterSnapshotAttributesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBClusterSnapshotAttributes_DBClusterSnapshotNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBClusterSnapshotAttributes");

            var request = InstantiateClassGenerator.Execute<DescribeDBClusterSnapshotAttributesRequest>();
            var marshaller = new DescribeDBClusterSnapshotAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterSnapshotNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeDBClusterSnapshotAttributesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBClusterSnapshotsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBClusterSnapshots");

            var request = InstantiateClassGenerator.Execute<DescribeDBClusterSnapshotsRequest>();
            var marshaller = new DescribeDBClusterSnapshotsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDBClusterSnapshotsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDBClusterSnapshotsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBClusterSnapshots_DBClusterSnapshotNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBClusterSnapshots");

            var request = InstantiateClassGenerator.Execute<DescribeDBClusterSnapshotsRequest>();
            var marshaller = new DescribeDBClusterSnapshotsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterSnapshotNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeDBClusterSnapshotsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBEngineVersionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBEngineVersions");

            var request = InstantiateClassGenerator.Execute<DescribeDBEngineVersionsRequest>();
            var marshaller = new DescribeDBEngineVersionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDBEngineVersionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDBEngineVersionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBInstanceAutomatedBackupsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBInstanceAutomatedBackups");

            var request = InstantiateClassGenerator.Execute<DescribeDBInstanceAutomatedBackupsRequest>();
            var marshaller = new DescribeDBInstanceAutomatedBackupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDBInstanceAutomatedBackupsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDBInstanceAutomatedBackupsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBInstanceAutomatedBackups_DBInstanceAutomatedBackupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBInstanceAutomatedBackups");

            var request = InstantiateClassGenerator.Execute<DescribeDBInstanceAutomatedBackupsRequest>();
            var marshaller = new DescribeDBInstanceAutomatedBackupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceAutomatedBackupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeDBInstanceAutomatedBackupsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBInstancesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBInstances");

            var request = InstantiateClassGenerator.Execute<DescribeDBInstancesRequest>();
            var marshaller = new DescribeDBInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDBInstancesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDBInstancesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBInstances_DBInstanceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBInstances");

            var request = InstantiateClassGenerator.Execute<DescribeDBInstancesRequest>();
            var marshaller = new DescribeDBInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeDBInstancesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBLogFilesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBLogFiles");

            var request = InstantiateClassGenerator.Execute<DescribeDBLogFilesRequest>();
            var marshaller = new DescribeDBLogFilesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDBLogFilesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDBLogFilesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBLogFiles_DBInstanceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBLogFiles");

            var request = InstantiateClassGenerator.Execute<DescribeDBLogFilesRequest>();
            var marshaller = new DescribeDBLogFilesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeDBLogFilesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBParameterGroupsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBParameterGroups");

            var request = InstantiateClassGenerator.Execute<DescribeDBParameterGroupsRequest>();
            var marshaller = new DescribeDBParameterGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDBParameterGroupsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDBParameterGroupsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBParameterGroups_DBParameterGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBParameterGroups");

            var request = InstantiateClassGenerator.Execute<DescribeDBParameterGroupsRequest>();
            var marshaller = new DescribeDBParameterGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBParameterGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeDBParameterGroupsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBParametersMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBParameters");

            var request = InstantiateClassGenerator.Execute<DescribeDBParametersRequest>();
            var marshaller = new DescribeDBParametersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDBParametersResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDBParametersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBParameters_DBParameterGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBParameters");

            var request = InstantiateClassGenerator.Execute<DescribeDBParametersRequest>();
            var marshaller = new DescribeDBParametersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBParameterGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeDBParametersResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBProxiesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBProxies");

            var request = InstantiateClassGenerator.Execute<DescribeDBProxiesRequest>();
            var marshaller = new DescribeDBProxiesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDBProxiesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDBProxiesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBProxies_DBProxyNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBProxies");

            var request = InstantiateClassGenerator.Execute<DescribeDBProxiesRequest>();
            var marshaller = new DescribeDBProxiesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBProxyNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeDBProxiesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBProxyEndpointsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBProxyEndpoints");

            var request = InstantiateClassGenerator.Execute<DescribeDBProxyEndpointsRequest>();
            var marshaller = new DescribeDBProxyEndpointsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDBProxyEndpointsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDBProxyEndpointsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBProxyEndpoints_DBProxyEndpointNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBProxyEndpoints");

            var request = InstantiateClassGenerator.Execute<DescribeDBProxyEndpointsRequest>();
            var marshaller = new DescribeDBProxyEndpointsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBProxyEndpointNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeDBProxyEndpointsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBProxyEndpoints_DBProxyNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBProxyEndpoints");

            var request = InstantiateClassGenerator.Execute<DescribeDBProxyEndpointsRequest>();
            var marshaller = new DescribeDBProxyEndpointsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBProxyNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeDBProxyEndpointsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBProxyTargetGroupsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBProxyTargetGroups");

            var request = InstantiateClassGenerator.Execute<DescribeDBProxyTargetGroupsRequest>();
            var marshaller = new DescribeDBProxyTargetGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDBProxyTargetGroupsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDBProxyTargetGroupsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBProxyTargetGroups_DBProxyNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBProxyTargetGroups");

            var request = InstantiateClassGenerator.Execute<DescribeDBProxyTargetGroupsRequest>();
            var marshaller = new DescribeDBProxyTargetGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBProxyNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeDBProxyTargetGroupsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBProxyTargetGroups_DBProxyTargetGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBProxyTargetGroups");

            var request = InstantiateClassGenerator.Execute<DescribeDBProxyTargetGroupsRequest>();
            var marshaller = new DescribeDBProxyTargetGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBProxyTargetGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeDBProxyTargetGroupsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBProxyTargetGroups_InvalidDBProxyStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBProxyTargetGroups");

            var request = InstantiateClassGenerator.Execute<DescribeDBProxyTargetGroupsRequest>();
            var marshaller = new DescribeDBProxyTargetGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBProxyStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeDBProxyTargetGroupsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBProxyTargetsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBProxyTargets");

            var request = InstantiateClassGenerator.Execute<DescribeDBProxyTargetsRequest>();
            var marshaller = new DescribeDBProxyTargetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDBProxyTargetsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDBProxyTargetsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBProxyTargets_DBProxyNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBProxyTargets");

            var request = InstantiateClassGenerator.Execute<DescribeDBProxyTargetsRequest>();
            var marshaller = new DescribeDBProxyTargetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBProxyNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeDBProxyTargetsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBProxyTargets_DBProxyTargetGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBProxyTargets");

            var request = InstantiateClassGenerator.Execute<DescribeDBProxyTargetsRequest>();
            var marshaller = new DescribeDBProxyTargetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBProxyTargetGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeDBProxyTargetsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBProxyTargets_DBProxyTargetNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBProxyTargets");

            var request = InstantiateClassGenerator.Execute<DescribeDBProxyTargetsRequest>();
            var marshaller = new DescribeDBProxyTargetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBProxyTargetNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeDBProxyTargetsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBProxyTargets_InvalidDBProxyStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBProxyTargets");

            var request = InstantiateClassGenerator.Execute<DescribeDBProxyTargetsRequest>();
            var marshaller = new DescribeDBProxyTargetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBProxyStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeDBProxyTargetsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBSecurityGroupsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBSecurityGroups");

            var request = InstantiateClassGenerator.Execute<DescribeDBSecurityGroupsRequest>();
            var marshaller = new DescribeDBSecurityGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDBSecurityGroupsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDBSecurityGroupsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBSecurityGroups_DBSecurityGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBSecurityGroups");

            var request = InstantiateClassGenerator.Execute<DescribeDBSecurityGroupsRequest>();
            var marshaller = new DescribeDBSecurityGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSecurityGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeDBSecurityGroupsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBSnapshotAttributesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBSnapshotAttributes");

            var request = InstantiateClassGenerator.Execute<DescribeDBSnapshotAttributesRequest>();
            var marshaller = new DescribeDBSnapshotAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDBSnapshotAttributesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDBSnapshotAttributesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBSnapshotAttributes_DBSnapshotNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBSnapshotAttributes");

            var request = InstantiateClassGenerator.Execute<DescribeDBSnapshotAttributesRequest>();
            var marshaller = new DescribeDBSnapshotAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSnapshotNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeDBSnapshotAttributesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBSnapshotsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBSnapshots");

            var request = InstantiateClassGenerator.Execute<DescribeDBSnapshotsRequest>();
            var marshaller = new DescribeDBSnapshotsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDBSnapshotsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDBSnapshotsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBSnapshots_DBSnapshotNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBSnapshots");

            var request = InstantiateClassGenerator.Execute<DescribeDBSnapshotsRequest>();
            var marshaller = new DescribeDBSnapshotsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSnapshotNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeDBSnapshotsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBSubnetGroupsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBSubnetGroups");

            var request = InstantiateClassGenerator.Execute<DescribeDBSubnetGroupsRequest>();
            var marshaller = new DescribeDBSubnetGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDBSubnetGroupsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDBSubnetGroupsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBSubnetGroups_DBSubnetGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBSubnetGroups");

            var request = InstantiateClassGenerator.Execute<DescribeDBSubnetGroupsRequest>();
            var marshaller = new DescribeDBSubnetGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSubnetGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeDBSubnetGroupsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeEngineDefaultClusterParametersMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeEngineDefaultClusterParameters");

            var request = InstantiateClassGenerator.Execute<DescribeEngineDefaultClusterParametersRequest>();
            var marshaller = new DescribeEngineDefaultClusterParametersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeEngineDefaultClusterParametersResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeEngineDefaultClusterParametersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeEngineDefaultParametersMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeEngineDefaultParameters");

            var request = InstantiateClassGenerator.Execute<DescribeEngineDefaultParametersRequest>();
            var marshaller = new DescribeEngineDefaultParametersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeEngineDefaultParametersResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeEngineDefaultParametersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeEventCategoriesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeEventCategories");

            var request = InstantiateClassGenerator.Execute<DescribeEventCategoriesRequest>();
            var marshaller = new DescribeEventCategoriesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeEventCategoriesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeEventCategoriesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeEventsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeEvents");

            var request = InstantiateClassGenerator.Execute<DescribeEventsRequest>();
            var marshaller = new DescribeEventsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeEventsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeEventsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeEventSubscriptionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeEventSubscriptions");

            var request = InstantiateClassGenerator.Execute<DescribeEventSubscriptionsRequest>();
            var marshaller = new DescribeEventSubscriptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeEventSubscriptionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeEventSubscriptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeEventSubscriptions_SubscriptionNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeEventSubscriptions");

            var request = InstantiateClassGenerator.Execute<DescribeEventSubscriptionsRequest>();
            var marshaller = new DescribeEventSubscriptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SubscriptionNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeEventSubscriptionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeExportTasksMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeExportTasks");

            var request = InstantiateClassGenerator.Execute<DescribeExportTasksRequest>();
            var marshaller = new DescribeExportTasksRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeExportTasksResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeExportTasksResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeExportTasks_ExportTaskNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeExportTasks");

            var request = InstantiateClassGenerator.Execute<DescribeExportTasksRequest>();
            var marshaller = new DescribeExportTasksRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ExportTaskNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeExportTasksResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeGlobalClustersMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeGlobalClusters");

            var request = InstantiateClassGenerator.Execute<DescribeGlobalClustersRequest>();
            var marshaller = new DescribeGlobalClustersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeGlobalClustersResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeGlobalClustersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeGlobalClusters_GlobalClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeGlobalClusters");

            var request = InstantiateClassGenerator.Execute<DescribeGlobalClustersRequest>();
            var marshaller = new DescribeGlobalClustersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("GlobalClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeGlobalClustersResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeOptionGroupOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeOptionGroupOptions");

            var request = InstantiateClassGenerator.Execute<DescribeOptionGroupOptionsRequest>();
            var marshaller = new DescribeOptionGroupOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeOptionGroupOptionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeOptionGroupOptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeOptionGroupsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeOptionGroups");

            var request = InstantiateClassGenerator.Execute<DescribeOptionGroupsRequest>();
            var marshaller = new DescribeOptionGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeOptionGroupsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeOptionGroupsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeOptionGroups_OptionGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeOptionGroups");

            var request = InstantiateClassGenerator.Execute<DescribeOptionGroupsRequest>();
            var marshaller = new DescribeOptionGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OptionGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeOptionGroupsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeOrderableDBInstanceOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeOrderableDBInstanceOptions");

            var request = InstantiateClassGenerator.Execute<DescribeOrderableDBInstanceOptionsRequest>();
            var marshaller = new DescribeOrderableDBInstanceOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeOrderableDBInstanceOptionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeOrderableDBInstanceOptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribePendingMaintenanceActionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribePendingMaintenanceActions");

            var request = InstantiateClassGenerator.Execute<DescribePendingMaintenanceActionsRequest>();
            var marshaller = new DescribePendingMaintenanceActionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribePendingMaintenanceActionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribePendingMaintenanceActionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribePendingMaintenanceActions_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribePendingMaintenanceActions");

            var request = InstantiateClassGenerator.Execute<DescribePendingMaintenanceActionsRequest>();
            var marshaller = new DescribePendingMaintenanceActionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribePendingMaintenanceActionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeReservedDBInstancesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeReservedDBInstances");

            var request = InstantiateClassGenerator.Execute<DescribeReservedDBInstancesRequest>();
            var marshaller = new DescribeReservedDBInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeReservedDBInstancesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeReservedDBInstancesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeReservedDBInstances_ReservedDBInstanceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeReservedDBInstances");

            var request = InstantiateClassGenerator.Execute<DescribeReservedDBInstancesRequest>();
            var marshaller = new DescribeReservedDBInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ReservedDBInstanceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeReservedDBInstancesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeReservedDBInstancesOfferingsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeReservedDBInstancesOfferings");

            var request = InstantiateClassGenerator.Execute<DescribeReservedDBInstancesOfferingsRequest>();
            var marshaller = new DescribeReservedDBInstancesOfferingsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeReservedDBInstancesOfferingsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeReservedDBInstancesOfferingsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeReservedDBInstancesOfferings_ReservedDBInstancesOfferingNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeReservedDBInstancesOfferings");

            var request = InstantiateClassGenerator.Execute<DescribeReservedDBInstancesOfferingsRequest>();
            var marshaller = new DescribeReservedDBInstancesOfferingsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ReservedDBInstancesOfferingNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeReservedDBInstancesOfferingsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeSourceRegionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSourceRegions");

            var request = InstantiateClassGenerator.Execute<DescribeSourceRegionsRequest>();
            var marshaller = new DescribeSourceRegionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeSourceRegionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeSourceRegionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeValidDBInstanceModificationsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeValidDBInstanceModifications");

            var request = InstantiateClassGenerator.Execute<DescribeValidDBInstanceModificationsRequest>();
            var marshaller = new DescribeValidDBInstanceModificationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeValidDBInstanceModificationsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeValidDBInstanceModificationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeValidDBInstanceModifications_DBInstanceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeValidDBInstanceModifications");

            var request = InstantiateClassGenerator.Execute<DescribeValidDBInstanceModificationsRequest>();
            var marshaller = new DescribeValidDBInstanceModificationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeValidDBInstanceModificationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeValidDBInstanceModifications_InvalidDBInstanceStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeValidDBInstanceModifications");

            var request = InstantiateClassGenerator.Execute<DescribeValidDBInstanceModificationsRequest>();
            var marshaller = new DescribeValidDBInstanceModificationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBInstanceStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeValidDBInstanceModificationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DownloadDBLogFilePortionMarshallTest()
        {
            var operation = service_model.FindOperation("DownloadDBLogFilePortion");

            var request = InstantiateClassGenerator.Execute<DownloadDBLogFilePortionRequest>();
            var marshaller = new DownloadDBLogFilePortionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DownloadDBLogFilePortionResponseUnmarshaller.Instance.Unmarshall(context)
                as DownloadDBLogFilePortionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DownloadDBLogFilePortion_DBInstanceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DownloadDBLogFilePortion");

            var request = InstantiateClassGenerator.Execute<DownloadDBLogFilePortionRequest>();
            var marshaller = new DownloadDBLogFilePortionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DownloadDBLogFilePortionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DownloadDBLogFilePortion_DBLogFileNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DownloadDBLogFilePortion");

            var request = InstantiateClassGenerator.Execute<DownloadDBLogFilePortionRequest>();
            var marshaller = new DownloadDBLogFilePortionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBLogFileNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DownloadDBLogFilePortionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void FailoverDBClusterMarshallTest()
        {
            var operation = service_model.FindOperation("FailoverDBCluster");

            var request = InstantiateClassGenerator.Execute<FailoverDBClusterRequest>();
            var marshaller = new FailoverDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = FailoverDBClusterResponseUnmarshaller.Instance.Unmarshall(context)
                as FailoverDBClusterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void FailoverDBCluster_DBClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("FailoverDBCluster");

            var request = InstantiateClassGenerator.Execute<FailoverDBClusterRequest>();
            var marshaller = new FailoverDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = FailoverDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void FailoverDBCluster_InvalidDBClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("FailoverDBCluster");

            var request = InstantiateClassGenerator.Execute<FailoverDBClusterRequest>();
            var marshaller = new FailoverDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = FailoverDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void FailoverDBCluster_InvalidDBInstanceStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("FailoverDBCluster");

            var request = InstantiateClassGenerator.Execute<FailoverDBClusterRequest>();
            var marshaller = new FailoverDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBInstanceStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = FailoverDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void FailoverGlobalClusterMarshallTest()
        {
            var operation = service_model.FindOperation("FailoverGlobalCluster");

            var request = InstantiateClassGenerator.Execute<FailoverGlobalClusterRequest>();
            var marshaller = new FailoverGlobalClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = FailoverGlobalClusterResponseUnmarshaller.Instance.Unmarshall(context)
                as FailoverGlobalClusterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void FailoverGlobalCluster_DBClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("FailoverGlobalCluster");

            var request = InstantiateClassGenerator.Execute<FailoverGlobalClusterRequest>();
            var marshaller = new FailoverGlobalClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = FailoverGlobalClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void FailoverGlobalCluster_GlobalClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("FailoverGlobalCluster");

            var request = InstantiateClassGenerator.Execute<FailoverGlobalClusterRequest>();
            var marshaller = new FailoverGlobalClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("GlobalClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = FailoverGlobalClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void FailoverGlobalCluster_InvalidDBClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("FailoverGlobalCluster");

            var request = InstantiateClassGenerator.Execute<FailoverGlobalClusterRequest>();
            var marshaller = new FailoverGlobalClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = FailoverGlobalClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void FailoverGlobalCluster_InvalidGlobalClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("FailoverGlobalCluster");

            var request = InstantiateClassGenerator.Execute<FailoverGlobalClusterRequest>();
            var marshaller = new FailoverGlobalClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidGlobalClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = FailoverGlobalClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ListTagsForResourceMarshallTest()
        {
            var operation = service_model.FindOperation("ListTagsForResource");

            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListTagsForResourceResponseUnmarshaller.Instance.Unmarshall(context)
                as ListTagsForResourceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ListTagsForResource_BlueGreenDeploymentNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListTagsForResource");

            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BlueGreenDeploymentNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ListTagsForResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ListTagsForResource_DBClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListTagsForResource");

            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ListTagsForResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ListTagsForResource_DBInstanceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListTagsForResource");

            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ListTagsForResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ListTagsForResource_DBProxyNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListTagsForResource");

            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBProxyNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ListTagsForResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ListTagsForResource_DBProxyTargetGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListTagsForResource");

            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBProxyTargetGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ListTagsForResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ListTagsForResource_DBSnapshotNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListTagsForResource");

            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSnapshotNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ListTagsForResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyActivityStreamMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyActivityStream");

            var request = InstantiateClassGenerator.Execute<ModifyActivityStreamRequest>();
            var marshaller = new ModifyActivityStreamRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyActivityStreamResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyActivityStreamResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyActivityStream_DBInstanceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyActivityStream");

            var request = InstantiateClassGenerator.Execute<ModifyActivityStreamRequest>();
            var marshaller = new ModifyActivityStreamRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyActivityStreamResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyActivityStream_InvalidDBInstanceStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyActivityStream");

            var request = InstantiateClassGenerator.Execute<ModifyActivityStreamRequest>();
            var marshaller = new ModifyActivityStreamRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBInstanceStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyActivityStreamResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyActivityStream_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyActivityStream");

            var request = InstantiateClassGenerator.Execute<ModifyActivityStreamRequest>();
            var marshaller = new ModifyActivityStreamRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyActivityStreamResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyCertificatesMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCertificates");

            var request = InstantiateClassGenerator.Execute<ModifyCertificatesRequest>();
            var marshaller = new ModifyCertificatesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyCertificatesResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyCertificatesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyCertificates_CertificateNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCertificates");

            var request = InstantiateClassGenerator.Execute<ModifyCertificatesRequest>();
            var marshaller = new ModifyCertificatesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CertificateNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyCertificatesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyCurrentDBClusterCapacityMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCurrentDBClusterCapacity");

            var request = InstantiateClassGenerator.Execute<ModifyCurrentDBClusterCapacityRequest>();
            var marshaller = new ModifyCurrentDBClusterCapacityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyCurrentDBClusterCapacityResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyCurrentDBClusterCapacityResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyCurrentDBClusterCapacity_DBClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCurrentDBClusterCapacity");

            var request = InstantiateClassGenerator.Execute<ModifyCurrentDBClusterCapacityRequest>();
            var marshaller = new ModifyCurrentDBClusterCapacityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyCurrentDBClusterCapacityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyCurrentDBClusterCapacity_InvalidDBClusterCapacityExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCurrentDBClusterCapacity");

            var request = InstantiateClassGenerator.Execute<ModifyCurrentDBClusterCapacityRequest>();
            var marshaller = new ModifyCurrentDBClusterCapacityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterCapacityException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyCurrentDBClusterCapacityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyCurrentDBClusterCapacity_InvalidDBClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCurrentDBClusterCapacity");

            var request = InstantiateClassGenerator.Execute<ModifyCurrentDBClusterCapacityRequest>();
            var marshaller = new ModifyCurrentDBClusterCapacityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyCurrentDBClusterCapacityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyCustomDBEngineVersionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCustomDBEngineVersion");

            var request = InstantiateClassGenerator.Execute<ModifyCustomDBEngineVersionRequest>();
            var marshaller = new ModifyCustomDBEngineVersionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyCustomDBEngineVersionResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyCustomDBEngineVersionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyCustomDBEngineVersion_CustomDBEngineVersionNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCustomDBEngineVersion");

            var request = InstantiateClassGenerator.Execute<ModifyCustomDBEngineVersionRequest>();
            var marshaller = new ModifyCustomDBEngineVersionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CustomDBEngineVersionNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyCustomDBEngineVersionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyCustomDBEngineVersion_InvalidCustomDBEngineVersionStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCustomDBEngineVersion");

            var request = InstantiateClassGenerator.Execute<ModifyCustomDBEngineVersionRequest>();
            var marshaller = new ModifyCustomDBEngineVersionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidCustomDBEngineVersionStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyCustomDBEngineVersionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBClusterMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBCluster");

            var request = InstantiateClassGenerator.Execute<ModifyDBClusterRequest>();
            var marshaller = new ModifyDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyDBClusterResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyDBClusterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBCluster_DBClusterAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBCluster");

            var request = InstantiateClassGenerator.Execute<ModifyDBClusterRequest>();
            var marshaller = new ModifyDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBCluster_DBClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBCluster");

            var request = InstantiateClassGenerator.Execute<ModifyDBClusterRequest>();
            var marshaller = new ModifyDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBCluster_DBClusterParameterGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBCluster");

            var request = InstantiateClassGenerator.Execute<ModifyDBClusterRequest>();
            var marshaller = new ModifyDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterParameterGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBCluster_DBSubnetGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBCluster");

            var request = InstantiateClassGenerator.Execute<ModifyDBClusterRequest>();
            var marshaller = new ModifyDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSubnetGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBCluster_DomainNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBCluster");

            var request = InstantiateClassGenerator.Execute<ModifyDBClusterRequest>();
            var marshaller = new ModifyDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DomainNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBCluster_InvalidDBClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBCluster");

            var request = InstantiateClassGenerator.Execute<ModifyDBClusterRequest>();
            var marshaller = new ModifyDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBCluster_InvalidDBInstanceStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBCluster");

            var request = InstantiateClassGenerator.Execute<ModifyDBClusterRequest>();
            var marshaller = new ModifyDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBInstanceStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBCluster_InvalidDBSecurityGroupStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBCluster");

            var request = InstantiateClassGenerator.Execute<ModifyDBClusterRequest>();
            var marshaller = new ModifyDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBSecurityGroupStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBCluster_InvalidDBSubnetGroupStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBCluster");

            var request = InstantiateClassGenerator.Execute<ModifyDBClusterRequest>();
            var marshaller = new ModifyDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBSubnetGroupStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBCluster_InvalidSubnetExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBCluster");

            var request = InstantiateClassGenerator.Execute<ModifyDBClusterRequest>();
            var marshaller = new ModifyDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidSubnetException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBCluster_InvalidVPCNetworkStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBCluster");

            var request = InstantiateClassGenerator.Execute<ModifyDBClusterRequest>();
            var marshaller = new ModifyDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidVPCNetworkStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBCluster_StorageQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBCluster");

            var request = InstantiateClassGenerator.Execute<ModifyDBClusterRequest>();
            var marshaller = new ModifyDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StorageQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBClusterEndpointMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBClusterEndpoint");

            var request = InstantiateClassGenerator.Execute<ModifyDBClusterEndpointRequest>();
            var marshaller = new ModifyDBClusterEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyDBClusterEndpointResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyDBClusterEndpointResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBClusterEndpoint_DBClusterEndpointNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBClusterEndpoint");

            var request = InstantiateClassGenerator.Execute<ModifyDBClusterEndpointRequest>();
            var marshaller = new ModifyDBClusterEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterEndpointNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBClusterEndpointResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBClusterEndpoint_DBInstanceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBClusterEndpoint");

            var request = InstantiateClassGenerator.Execute<ModifyDBClusterEndpointRequest>();
            var marshaller = new ModifyDBClusterEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBClusterEndpointResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBClusterEndpoint_InvalidDBClusterEndpointStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBClusterEndpoint");

            var request = InstantiateClassGenerator.Execute<ModifyDBClusterEndpointRequest>();
            var marshaller = new ModifyDBClusterEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterEndpointStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBClusterEndpointResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBClusterEndpoint_InvalidDBClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBClusterEndpoint");

            var request = InstantiateClassGenerator.Execute<ModifyDBClusterEndpointRequest>();
            var marshaller = new ModifyDBClusterEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBClusterEndpointResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBClusterEndpoint_InvalidDBInstanceStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBClusterEndpoint");

            var request = InstantiateClassGenerator.Execute<ModifyDBClusterEndpointRequest>();
            var marshaller = new ModifyDBClusterEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBInstanceStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBClusterEndpointResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBClusterParameterGroupMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<ModifyDBClusterParameterGroupRequest>();
            var marshaller = new ModifyDBClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyDBClusterParameterGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyDBClusterParameterGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBClusterParameterGroup_DBParameterGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<ModifyDBClusterParameterGroupRequest>();
            var marshaller = new ModifyDBClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBParameterGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBClusterParameterGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBClusterParameterGroup_InvalidDBParameterGroupStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<ModifyDBClusterParameterGroupRequest>();
            var marshaller = new ModifyDBClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBParameterGroupStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBClusterParameterGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBClusterSnapshotAttributeMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBClusterSnapshotAttribute");

            var request = InstantiateClassGenerator.Execute<ModifyDBClusterSnapshotAttributeRequest>();
            var marshaller = new ModifyDBClusterSnapshotAttributeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyDBClusterSnapshotAttributeResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyDBClusterSnapshotAttributeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBClusterSnapshotAttribute_DBClusterSnapshotNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBClusterSnapshotAttribute");

            var request = InstantiateClassGenerator.Execute<ModifyDBClusterSnapshotAttributeRequest>();
            var marshaller = new ModifyDBClusterSnapshotAttributeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterSnapshotNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBClusterSnapshotAttributeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBClusterSnapshotAttribute_InvalidDBClusterSnapshotStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBClusterSnapshotAttribute");

            var request = InstantiateClassGenerator.Execute<ModifyDBClusterSnapshotAttributeRequest>();
            var marshaller = new ModifyDBClusterSnapshotAttributeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterSnapshotStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBClusterSnapshotAttributeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBClusterSnapshotAttribute_SharedSnapshotQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBClusterSnapshotAttribute");

            var request = InstantiateClassGenerator.Execute<ModifyDBClusterSnapshotAttributeRequest>();
            var marshaller = new ModifyDBClusterSnapshotAttributeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SharedSnapshotQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBClusterSnapshotAttributeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBInstanceMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBInstance");

            var request = InstantiateClassGenerator.Execute<ModifyDBInstanceRequest>();
            var marshaller = new ModifyDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyDBInstanceResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyDBInstanceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBInstance_AuthorizationNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBInstance");

            var request = InstantiateClassGenerator.Execute<ModifyDBInstanceRequest>();
            var marshaller = new ModifyDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AuthorizationNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBInstance_BackupPolicyNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBInstance");

            var request = InstantiateClassGenerator.Execute<ModifyDBInstanceRequest>();
            var marshaller = new ModifyDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BackupPolicyNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBInstance_CertificateNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBInstance");

            var request = InstantiateClassGenerator.Execute<ModifyDBInstanceRequest>();
            var marshaller = new ModifyDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CertificateNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBInstance_DBInstanceAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBInstance");

            var request = InstantiateClassGenerator.Execute<ModifyDBInstanceRequest>();
            var marshaller = new ModifyDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBInstance_DBInstanceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBInstance");

            var request = InstantiateClassGenerator.Execute<ModifyDBInstanceRequest>();
            var marshaller = new ModifyDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBInstance_DBParameterGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBInstance");

            var request = InstantiateClassGenerator.Execute<ModifyDBInstanceRequest>();
            var marshaller = new ModifyDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBParameterGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBInstance_DBSecurityGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBInstance");

            var request = InstantiateClassGenerator.Execute<ModifyDBInstanceRequest>();
            var marshaller = new ModifyDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSecurityGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBInstance_DBUpgradeDependencyFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBInstance");

            var request = InstantiateClassGenerator.Execute<ModifyDBInstanceRequest>();
            var marshaller = new ModifyDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBUpgradeDependencyFailureException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBInstance_DomainNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBInstance");

            var request = InstantiateClassGenerator.Execute<ModifyDBInstanceRequest>();
            var marshaller = new ModifyDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DomainNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBInstance_InsufficientDBInstanceCapacityExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBInstance");

            var request = InstantiateClassGenerator.Execute<ModifyDBInstanceRequest>();
            var marshaller = new ModifyDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientDBInstanceCapacityException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBInstance_InvalidDBClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBInstance");

            var request = InstantiateClassGenerator.Execute<ModifyDBInstanceRequest>();
            var marshaller = new ModifyDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBInstance_InvalidDBInstanceStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBInstance");

            var request = InstantiateClassGenerator.Execute<ModifyDBInstanceRequest>();
            var marshaller = new ModifyDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBInstanceStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBInstance_InvalidDBSecurityGroupStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBInstance");

            var request = InstantiateClassGenerator.Execute<ModifyDBInstanceRequest>();
            var marshaller = new ModifyDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBSecurityGroupStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBInstance_InvalidVPCNetworkStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBInstance");

            var request = InstantiateClassGenerator.Execute<ModifyDBInstanceRequest>();
            var marshaller = new ModifyDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidVPCNetworkStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBInstance_KMSKeyNotAccessibleExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBInstance");

            var request = InstantiateClassGenerator.Execute<ModifyDBInstanceRequest>();
            var marshaller = new ModifyDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("KMSKeyNotAccessibleException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBInstance_NetworkTypeNotSupportedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBInstance");

            var request = InstantiateClassGenerator.Execute<ModifyDBInstanceRequest>();
            var marshaller = new ModifyDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("NetworkTypeNotSupportedException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBInstance_OptionGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBInstance");

            var request = InstantiateClassGenerator.Execute<ModifyDBInstanceRequest>();
            var marshaller = new ModifyDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OptionGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBInstance_ProvisionedIopsNotAvailableInAZExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBInstance");

            var request = InstantiateClassGenerator.Execute<ModifyDBInstanceRequest>();
            var marshaller = new ModifyDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ProvisionedIopsNotAvailableInAZException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBInstance_StorageQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBInstance");

            var request = InstantiateClassGenerator.Execute<ModifyDBInstanceRequest>();
            var marshaller = new ModifyDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StorageQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBInstance_StorageTypeNotSupportedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBInstance");

            var request = InstantiateClassGenerator.Execute<ModifyDBInstanceRequest>();
            var marshaller = new ModifyDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StorageTypeNotSupportedException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBParameterGroupMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBParameterGroup");

            var request = InstantiateClassGenerator.Execute<ModifyDBParameterGroupRequest>();
            var marshaller = new ModifyDBParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyDBParameterGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyDBParameterGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBParameterGroup_DBParameterGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBParameterGroup");

            var request = InstantiateClassGenerator.Execute<ModifyDBParameterGroupRequest>();
            var marshaller = new ModifyDBParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBParameterGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBParameterGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBParameterGroup_InvalidDBParameterGroupStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBParameterGroup");

            var request = InstantiateClassGenerator.Execute<ModifyDBParameterGroupRequest>();
            var marshaller = new ModifyDBParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBParameterGroupStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBParameterGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBProxyMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBProxy");

            var request = InstantiateClassGenerator.Execute<ModifyDBProxyRequest>();
            var marshaller = new ModifyDBProxyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyDBProxyResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyDBProxyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBProxy_DBProxyAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBProxy");

            var request = InstantiateClassGenerator.Execute<ModifyDBProxyRequest>();
            var marshaller = new ModifyDBProxyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBProxyAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBProxyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBProxy_DBProxyNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBProxy");

            var request = InstantiateClassGenerator.Execute<ModifyDBProxyRequest>();
            var marshaller = new ModifyDBProxyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBProxyNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBProxyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBProxy_InvalidDBProxyStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBProxy");

            var request = InstantiateClassGenerator.Execute<ModifyDBProxyRequest>();
            var marshaller = new ModifyDBProxyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBProxyStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBProxyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBProxyEndpointMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBProxyEndpoint");

            var request = InstantiateClassGenerator.Execute<ModifyDBProxyEndpointRequest>();
            var marshaller = new ModifyDBProxyEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyDBProxyEndpointResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyDBProxyEndpointResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBProxyEndpoint_DBProxyEndpointAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBProxyEndpoint");

            var request = InstantiateClassGenerator.Execute<ModifyDBProxyEndpointRequest>();
            var marshaller = new ModifyDBProxyEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBProxyEndpointAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBProxyEndpointResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBProxyEndpoint_DBProxyEndpointNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBProxyEndpoint");

            var request = InstantiateClassGenerator.Execute<ModifyDBProxyEndpointRequest>();
            var marshaller = new ModifyDBProxyEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBProxyEndpointNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBProxyEndpointResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBProxyEndpoint_InvalidDBProxyEndpointStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBProxyEndpoint");

            var request = InstantiateClassGenerator.Execute<ModifyDBProxyEndpointRequest>();
            var marshaller = new ModifyDBProxyEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBProxyEndpointStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBProxyEndpointResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBProxyEndpoint_InvalidDBProxyStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBProxyEndpoint");

            var request = InstantiateClassGenerator.Execute<ModifyDBProxyEndpointRequest>();
            var marshaller = new ModifyDBProxyEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBProxyStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBProxyEndpointResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBProxyTargetGroupMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBProxyTargetGroup");

            var request = InstantiateClassGenerator.Execute<ModifyDBProxyTargetGroupRequest>();
            var marshaller = new ModifyDBProxyTargetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyDBProxyTargetGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyDBProxyTargetGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBProxyTargetGroup_DBProxyNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBProxyTargetGroup");

            var request = InstantiateClassGenerator.Execute<ModifyDBProxyTargetGroupRequest>();
            var marshaller = new ModifyDBProxyTargetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBProxyNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBProxyTargetGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBProxyTargetGroup_DBProxyTargetGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBProxyTargetGroup");

            var request = InstantiateClassGenerator.Execute<ModifyDBProxyTargetGroupRequest>();
            var marshaller = new ModifyDBProxyTargetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBProxyTargetGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBProxyTargetGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBProxyTargetGroup_InvalidDBProxyStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBProxyTargetGroup");

            var request = InstantiateClassGenerator.Execute<ModifyDBProxyTargetGroupRequest>();
            var marshaller = new ModifyDBProxyTargetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBProxyStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBProxyTargetGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBSnapshotMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBSnapshot");

            var request = InstantiateClassGenerator.Execute<ModifyDBSnapshotRequest>();
            var marshaller = new ModifyDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyDBSnapshotResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyDBSnapshotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBSnapshot_DBSnapshotNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBSnapshot");

            var request = InstantiateClassGenerator.Execute<ModifyDBSnapshotRequest>();
            var marshaller = new ModifyDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSnapshotNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBSnapshotAttributeMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBSnapshotAttribute");

            var request = InstantiateClassGenerator.Execute<ModifyDBSnapshotAttributeRequest>();
            var marshaller = new ModifyDBSnapshotAttributeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyDBSnapshotAttributeResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyDBSnapshotAttributeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBSnapshotAttribute_DBSnapshotNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBSnapshotAttribute");

            var request = InstantiateClassGenerator.Execute<ModifyDBSnapshotAttributeRequest>();
            var marshaller = new ModifyDBSnapshotAttributeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSnapshotNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBSnapshotAttributeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBSnapshotAttribute_InvalidDBSnapshotStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBSnapshotAttribute");

            var request = InstantiateClassGenerator.Execute<ModifyDBSnapshotAttributeRequest>();
            var marshaller = new ModifyDBSnapshotAttributeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBSnapshotStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBSnapshotAttributeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBSnapshotAttribute_SharedSnapshotQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBSnapshotAttribute");

            var request = InstantiateClassGenerator.Execute<ModifyDBSnapshotAttributeRequest>();
            var marshaller = new ModifyDBSnapshotAttributeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SharedSnapshotQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBSnapshotAttributeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBSubnetGroupMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBSubnetGroup");

            var request = InstantiateClassGenerator.Execute<ModifyDBSubnetGroupRequest>();
            var marshaller = new ModifyDBSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyDBSubnetGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyDBSubnetGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBSubnetGroup_DBSubnetGroupDoesNotCoverEnoughAZsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBSubnetGroup");

            var request = InstantiateClassGenerator.Execute<ModifyDBSubnetGroupRequest>();
            var marshaller = new ModifyDBSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSubnetGroupDoesNotCoverEnoughAZsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBSubnetGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBSubnetGroup_DBSubnetGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBSubnetGroup");

            var request = InstantiateClassGenerator.Execute<ModifyDBSubnetGroupRequest>();
            var marshaller = new ModifyDBSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSubnetGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBSubnetGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBSubnetGroup_DBSubnetQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBSubnetGroup");

            var request = InstantiateClassGenerator.Execute<ModifyDBSubnetGroupRequest>();
            var marshaller = new ModifyDBSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSubnetQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBSubnetGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBSubnetGroup_InvalidSubnetExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBSubnetGroup");

            var request = InstantiateClassGenerator.Execute<ModifyDBSubnetGroupRequest>();
            var marshaller = new ModifyDBSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidSubnetException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBSubnetGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyDBSubnetGroup_SubnetAlreadyInUseExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBSubnetGroup");

            var request = InstantiateClassGenerator.Execute<ModifyDBSubnetGroupRequest>();
            var marshaller = new ModifyDBSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SubnetAlreadyInUseException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyDBSubnetGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyEventSubscriptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyEventSubscription");

            var request = InstantiateClassGenerator.Execute<ModifyEventSubscriptionRequest>();
            var marshaller = new ModifyEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyEventSubscriptionResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyEventSubscriptionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyEventSubscription_EventSubscriptionQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyEventSubscription");

            var request = InstantiateClassGenerator.Execute<ModifyEventSubscriptionRequest>();
            var marshaller = new ModifyEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("EventSubscriptionQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyEventSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyEventSubscription_SNSInvalidTopicExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyEventSubscription");

            var request = InstantiateClassGenerator.Execute<ModifyEventSubscriptionRequest>();
            var marshaller = new ModifyEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SNSInvalidTopicException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyEventSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyEventSubscription_SNSNoAuthorizationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyEventSubscription");

            var request = InstantiateClassGenerator.Execute<ModifyEventSubscriptionRequest>();
            var marshaller = new ModifyEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SNSNoAuthorizationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyEventSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyEventSubscription_SNSTopicArnNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyEventSubscription");

            var request = InstantiateClassGenerator.Execute<ModifyEventSubscriptionRequest>();
            var marshaller = new ModifyEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SNSTopicArnNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyEventSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyEventSubscription_SubscriptionCategoryNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyEventSubscription");

            var request = InstantiateClassGenerator.Execute<ModifyEventSubscriptionRequest>();
            var marshaller = new ModifyEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SubscriptionCategoryNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyEventSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyEventSubscription_SubscriptionNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyEventSubscription");

            var request = InstantiateClassGenerator.Execute<ModifyEventSubscriptionRequest>();
            var marshaller = new ModifyEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SubscriptionNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyEventSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyGlobalClusterMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyGlobalCluster");

            var request = InstantiateClassGenerator.Execute<ModifyGlobalClusterRequest>();
            var marshaller = new ModifyGlobalClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyGlobalClusterResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyGlobalClusterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyGlobalCluster_GlobalClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyGlobalCluster");

            var request = InstantiateClassGenerator.Execute<ModifyGlobalClusterRequest>();
            var marshaller = new ModifyGlobalClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("GlobalClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyGlobalClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyGlobalCluster_InvalidDBClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyGlobalCluster");

            var request = InstantiateClassGenerator.Execute<ModifyGlobalClusterRequest>();
            var marshaller = new ModifyGlobalClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyGlobalClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyGlobalCluster_InvalidDBInstanceStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyGlobalCluster");

            var request = InstantiateClassGenerator.Execute<ModifyGlobalClusterRequest>();
            var marshaller = new ModifyGlobalClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBInstanceStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyGlobalClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyGlobalCluster_InvalidGlobalClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyGlobalCluster");

            var request = InstantiateClassGenerator.Execute<ModifyGlobalClusterRequest>();
            var marshaller = new ModifyGlobalClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidGlobalClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyGlobalClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyOptionGroupMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyOptionGroup");

            var request = InstantiateClassGenerator.Execute<ModifyOptionGroupRequest>();
            var marshaller = new ModifyOptionGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyOptionGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyOptionGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyOptionGroup_InvalidOptionGroupStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyOptionGroup");

            var request = InstantiateClassGenerator.Execute<ModifyOptionGroupRequest>();
            var marshaller = new ModifyOptionGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidOptionGroupStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyOptionGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ModifyOptionGroup_OptionGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyOptionGroup");

            var request = InstantiateClassGenerator.Execute<ModifyOptionGroupRequest>();
            var marshaller = new ModifyOptionGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OptionGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyOptionGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void PromoteReadReplicaMarshallTest()
        {
            var operation = service_model.FindOperation("PromoteReadReplica");

            var request = InstantiateClassGenerator.Execute<PromoteReadReplicaRequest>();
            var marshaller = new PromoteReadReplicaRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = PromoteReadReplicaResponseUnmarshaller.Instance.Unmarshall(context)
                as PromoteReadReplicaResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void PromoteReadReplica_DBInstanceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PromoteReadReplica");

            var request = InstantiateClassGenerator.Execute<PromoteReadReplicaRequest>();
            var marshaller = new PromoteReadReplicaRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = PromoteReadReplicaResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void PromoteReadReplica_InvalidDBInstanceStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PromoteReadReplica");

            var request = InstantiateClassGenerator.Execute<PromoteReadReplicaRequest>();
            var marshaller = new PromoteReadReplicaRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBInstanceStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = PromoteReadReplicaResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void PromoteReadReplicaDBClusterMarshallTest()
        {
            var operation = service_model.FindOperation("PromoteReadReplicaDBCluster");

            var request = InstantiateClassGenerator.Execute<PromoteReadReplicaDBClusterRequest>();
            var marshaller = new PromoteReadReplicaDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = PromoteReadReplicaDBClusterResponseUnmarshaller.Instance.Unmarshall(context)
                as PromoteReadReplicaDBClusterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void PromoteReadReplicaDBCluster_DBClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PromoteReadReplicaDBCluster");

            var request = InstantiateClassGenerator.Execute<PromoteReadReplicaDBClusterRequest>();
            var marshaller = new PromoteReadReplicaDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = PromoteReadReplicaDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void PromoteReadReplicaDBCluster_InvalidDBClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PromoteReadReplicaDBCluster");

            var request = InstantiateClassGenerator.Execute<PromoteReadReplicaDBClusterRequest>();
            var marshaller = new PromoteReadReplicaDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = PromoteReadReplicaDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void PurchaseReservedDBInstancesOfferingMarshallTest()
        {
            var operation = service_model.FindOperation("PurchaseReservedDBInstancesOffering");

            var request = InstantiateClassGenerator.Execute<PurchaseReservedDBInstancesOfferingRequest>();
            var marshaller = new PurchaseReservedDBInstancesOfferingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = PurchaseReservedDBInstancesOfferingResponseUnmarshaller.Instance.Unmarshall(context)
                as PurchaseReservedDBInstancesOfferingResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void PurchaseReservedDBInstancesOffering_ReservedDBInstanceAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PurchaseReservedDBInstancesOffering");

            var request = InstantiateClassGenerator.Execute<PurchaseReservedDBInstancesOfferingRequest>();
            var marshaller = new PurchaseReservedDBInstancesOfferingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ReservedDBInstanceAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = PurchaseReservedDBInstancesOfferingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void PurchaseReservedDBInstancesOffering_ReservedDBInstanceQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PurchaseReservedDBInstancesOffering");

            var request = InstantiateClassGenerator.Execute<PurchaseReservedDBInstancesOfferingRequest>();
            var marshaller = new PurchaseReservedDBInstancesOfferingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ReservedDBInstanceQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = PurchaseReservedDBInstancesOfferingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void PurchaseReservedDBInstancesOffering_ReservedDBInstancesOfferingNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PurchaseReservedDBInstancesOffering");

            var request = InstantiateClassGenerator.Execute<PurchaseReservedDBInstancesOfferingRequest>();
            var marshaller = new PurchaseReservedDBInstancesOfferingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ReservedDBInstancesOfferingNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = PurchaseReservedDBInstancesOfferingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RebootDBClusterMarshallTest()
        {
            var operation = service_model.FindOperation("RebootDBCluster");

            var request = InstantiateClassGenerator.Execute<RebootDBClusterRequest>();
            var marshaller = new RebootDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RebootDBClusterResponseUnmarshaller.Instance.Unmarshall(context)
                as RebootDBClusterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RebootDBCluster_DBClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RebootDBCluster");

            var request = InstantiateClassGenerator.Execute<RebootDBClusterRequest>();
            var marshaller = new RebootDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RebootDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RebootDBCluster_InvalidDBClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RebootDBCluster");

            var request = InstantiateClassGenerator.Execute<RebootDBClusterRequest>();
            var marshaller = new RebootDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RebootDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RebootDBCluster_InvalidDBInstanceStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RebootDBCluster");

            var request = InstantiateClassGenerator.Execute<RebootDBClusterRequest>();
            var marshaller = new RebootDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBInstanceStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RebootDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RebootDBInstanceMarshallTest()
        {
            var operation = service_model.FindOperation("RebootDBInstance");

            var request = InstantiateClassGenerator.Execute<RebootDBInstanceRequest>();
            var marshaller = new RebootDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RebootDBInstanceResponseUnmarshaller.Instance.Unmarshall(context)
                as RebootDBInstanceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RebootDBInstance_DBInstanceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RebootDBInstance");

            var request = InstantiateClassGenerator.Execute<RebootDBInstanceRequest>();
            var marshaller = new RebootDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RebootDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RebootDBInstance_InvalidDBInstanceStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RebootDBInstance");

            var request = InstantiateClassGenerator.Execute<RebootDBInstanceRequest>();
            var marshaller = new RebootDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBInstanceStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RebootDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RegisterDBProxyTargetsMarshallTest()
        {
            var operation = service_model.FindOperation("RegisterDBProxyTargets");

            var request = InstantiateClassGenerator.Execute<RegisterDBProxyTargetsRequest>();
            var marshaller = new RegisterDBProxyTargetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RegisterDBProxyTargetsResponseUnmarshaller.Instance.Unmarshall(context)
                as RegisterDBProxyTargetsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RegisterDBProxyTargets_DBClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RegisterDBProxyTargets");

            var request = InstantiateClassGenerator.Execute<RegisterDBProxyTargetsRequest>();
            var marshaller = new RegisterDBProxyTargetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RegisterDBProxyTargetsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RegisterDBProxyTargets_DBInstanceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RegisterDBProxyTargets");

            var request = InstantiateClassGenerator.Execute<RegisterDBProxyTargetsRequest>();
            var marshaller = new RegisterDBProxyTargetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RegisterDBProxyTargetsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RegisterDBProxyTargets_DBProxyNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RegisterDBProxyTargets");

            var request = InstantiateClassGenerator.Execute<RegisterDBProxyTargetsRequest>();
            var marshaller = new RegisterDBProxyTargetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBProxyNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RegisterDBProxyTargetsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RegisterDBProxyTargets_DBProxyTargetAlreadyRegisteredExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RegisterDBProxyTargets");

            var request = InstantiateClassGenerator.Execute<RegisterDBProxyTargetsRequest>();
            var marshaller = new RegisterDBProxyTargetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBProxyTargetAlreadyRegisteredException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RegisterDBProxyTargetsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RegisterDBProxyTargets_DBProxyTargetGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RegisterDBProxyTargets");

            var request = InstantiateClassGenerator.Execute<RegisterDBProxyTargetsRequest>();
            var marshaller = new RegisterDBProxyTargetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBProxyTargetGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RegisterDBProxyTargetsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RegisterDBProxyTargets_InsufficientAvailableIPsInSubnetExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RegisterDBProxyTargets");

            var request = InstantiateClassGenerator.Execute<RegisterDBProxyTargetsRequest>();
            var marshaller = new RegisterDBProxyTargetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientAvailableIPsInSubnetException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RegisterDBProxyTargetsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RegisterDBProxyTargets_InvalidDBClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RegisterDBProxyTargets");

            var request = InstantiateClassGenerator.Execute<RegisterDBProxyTargetsRequest>();
            var marshaller = new RegisterDBProxyTargetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RegisterDBProxyTargetsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RegisterDBProxyTargets_InvalidDBInstanceStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RegisterDBProxyTargets");

            var request = InstantiateClassGenerator.Execute<RegisterDBProxyTargetsRequest>();
            var marshaller = new RegisterDBProxyTargetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBInstanceStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RegisterDBProxyTargetsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RegisterDBProxyTargets_InvalidDBProxyStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RegisterDBProxyTargets");

            var request = InstantiateClassGenerator.Execute<RegisterDBProxyTargetsRequest>();
            var marshaller = new RegisterDBProxyTargetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBProxyStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RegisterDBProxyTargetsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RemoveFromGlobalClusterMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveFromGlobalCluster");

            var request = InstantiateClassGenerator.Execute<RemoveFromGlobalClusterRequest>();
            var marshaller = new RemoveFromGlobalClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RemoveFromGlobalClusterResponseUnmarshaller.Instance.Unmarshall(context)
                as RemoveFromGlobalClusterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RemoveFromGlobalCluster_DBClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveFromGlobalCluster");

            var request = InstantiateClassGenerator.Execute<RemoveFromGlobalClusterRequest>();
            var marshaller = new RemoveFromGlobalClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RemoveFromGlobalClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RemoveFromGlobalCluster_GlobalClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveFromGlobalCluster");

            var request = InstantiateClassGenerator.Execute<RemoveFromGlobalClusterRequest>();
            var marshaller = new RemoveFromGlobalClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("GlobalClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RemoveFromGlobalClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RemoveFromGlobalCluster_InvalidGlobalClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveFromGlobalCluster");

            var request = InstantiateClassGenerator.Execute<RemoveFromGlobalClusterRequest>();
            var marshaller = new RemoveFromGlobalClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidGlobalClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RemoveFromGlobalClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RemoveRoleFromDBClusterMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveRoleFromDBCluster");

            var request = InstantiateClassGenerator.Execute<RemoveRoleFromDBClusterRequest>();
            var marshaller = new RemoveRoleFromDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RemoveRoleFromDBCluster_DBClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveRoleFromDBCluster");

            var request = InstantiateClassGenerator.Execute<RemoveRoleFromDBClusterRequest>();
            var marshaller = new RemoveRoleFromDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RemoveRoleFromDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RemoveRoleFromDBCluster_DBClusterRoleNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveRoleFromDBCluster");

            var request = InstantiateClassGenerator.Execute<RemoveRoleFromDBClusterRequest>();
            var marshaller = new RemoveRoleFromDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterRoleNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RemoveRoleFromDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RemoveRoleFromDBCluster_InvalidDBClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveRoleFromDBCluster");

            var request = InstantiateClassGenerator.Execute<RemoveRoleFromDBClusterRequest>();
            var marshaller = new RemoveRoleFromDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RemoveRoleFromDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RemoveRoleFromDBInstanceMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveRoleFromDBInstance");

            var request = InstantiateClassGenerator.Execute<RemoveRoleFromDBInstanceRequest>();
            var marshaller = new RemoveRoleFromDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RemoveRoleFromDBInstance_DBInstanceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveRoleFromDBInstance");

            var request = InstantiateClassGenerator.Execute<RemoveRoleFromDBInstanceRequest>();
            var marshaller = new RemoveRoleFromDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RemoveRoleFromDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RemoveRoleFromDBInstance_DBInstanceRoleNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveRoleFromDBInstance");

            var request = InstantiateClassGenerator.Execute<RemoveRoleFromDBInstanceRequest>();
            var marshaller = new RemoveRoleFromDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceRoleNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RemoveRoleFromDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RemoveRoleFromDBInstance_InvalidDBInstanceStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveRoleFromDBInstance");

            var request = InstantiateClassGenerator.Execute<RemoveRoleFromDBInstanceRequest>();
            var marshaller = new RemoveRoleFromDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBInstanceStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RemoveRoleFromDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RemoveSourceIdentifierFromSubscriptionMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveSourceIdentifierFromSubscription");

            var request = InstantiateClassGenerator.Execute<RemoveSourceIdentifierFromSubscriptionRequest>();
            var marshaller = new RemoveSourceIdentifierFromSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RemoveSourceIdentifierFromSubscriptionResponseUnmarshaller.Instance.Unmarshall(context)
                as RemoveSourceIdentifierFromSubscriptionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RemoveSourceIdentifierFromSubscription_SourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveSourceIdentifierFromSubscription");

            var request = InstantiateClassGenerator.Execute<RemoveSourceIdentifierFromSubscriptionRequest>();
            var marshaller = new RemoveSourceIdentifierFromSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RemoveSourceIdentifierFromSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RemoveSourceIdentifierFromSubscription_SubscriptionNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveSourceIdentifierFromSubscription");

            var request = InstantiateClassGenerator.Execute<RemoveSourceIdentifierFromSubscriptionRequest>();
            var marshaller = new RemoveSourceIdentifierFromSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SubscriptionNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RemoveSourceIdentifierFromSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RemoveTagsFromResourceMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveTagsFromResource");

            var request = InstantiateClassGenerator.Execute<RemoveTagsFromResourceRequest>();
            var marshaller = new RemoveTagsFromResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RemoveTagsFromResource_BlueGreenDeploymentNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveTagsFromResource");

            var request = InstantiateClassGenerator.Execute<RemoveTagsFromResourceRequest>();
            var marshaller = new RemoveTagsFromResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BlueGreenDeploymentNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RemoveTagsFromResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RemoveTagsFromResource_DBClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveTagsFromResource");

            var request = InstantiateClassGenerator.Execute<RemoveTagsFromResourceRequest>();
            var marshaller = new RemoveTagsFromResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RemoveTagsFromResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RemoveTagsFromResource_DBInstanceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveTagsFromResource");

            var request = InstantiateClassGenerator.Execute<RemoveTagsFromResourceRequest>();
            var marshaller = new RemoveTagsFromResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RemoveTagsFromResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RemoveTagsFromResource_DBProxyNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveTagsFromResource");

            var request = InstantiateClassGenerator.Execute<RemoveTagsFromResourceRequest>();
            var marshaller = new RemoveTagsFromResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBProxyNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RemoveTagsFromResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RemoveTagsFromResource_DBProxyTargetGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveTagsFromResource");

            var request = InstantiateClassGenerator.Execute<RemoveTagsFromResourceRequest>();
            var marshaller = new RemoveTagsFromResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBProxyTargetGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RemoveTagsFromResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RemoveTagsFromResource_DBSnapshotNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveTagsFromResource");

            var request = InstantiateClassGenerator.Execute<RemoveTagsFromResourceRequest>();
            var marshaller = new RemoveTagsFromResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSnapshotNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RemoveTagsFromResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ResetDBClusterParameterGroupMarshallTest()
        {
            var operation = service_model.FindOperation("ResetDBClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<ResetDBClusterParameterGroupRequest>();
            var marshaller = new ResetDBClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ResetDBClusterParameterGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as ResetDBClusterParameterGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ResetDBClusterParameterGroup_DBParameterGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ResetDBClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<ResetDBClusterParameterGroupRequest>();
            var marshaller = new ResetDBClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBParameterGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ResetDBClusterParameterGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ResetDBClusterParameterGroup_InvalidDBParameterGroupStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ResetDBClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<ResetDBClusterParameterGroupRequest>();
            var marshaller = new ResetDBClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBParameterGroupStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ResetDBClusterParameterGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ResetDBParameterGroupMarshallTest()
        {
            var operation = service_model.FindOperation("ResetDBParameterGroup");

            var request = InstantiateClassGenerator.Execute<ResetDBParameterGroupRequest>();
            var marshaller = new ResetDBParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ResetDBParameterGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as ResetDBParameterGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ResetDBParameterGroup_DBParameterGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ResetDBParameterGroup");

            var request = InstantiateClassGenerator.Execute<ResetDBParameterGroupRequest>();
            var marshaller = new ResetDBParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBParameterGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ResetDBParameterGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void ResetDBParameterGroup_InvalidDBParameterGroupStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ResetDBParameterGroup");

            var request = InstantiateClassGenerator.Execute<ResetDBParameterGroupRequest>();
            var marshaller = new ResetDBParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBParameterGroupStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ResetDBParameterGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterFromS3MarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterFromS3");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterFromS3Request>();
            var marshaller = new RestoreDBClusterFromS3RequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RestoreDBClusterFromS3ResponseUnmarshaller.Instance.Unmarshall(context)
                as RestoreDBClusterFromS3Response;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterFromS3_DBClusterAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterFromS3");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterFromS3Request>();
            var marshaller = new RestoreDBClusterFromS3RequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterFromS3ResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterFromS3_DBClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterFromS3");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterFromS3Request>();
            var marshaller = new RestoreDBClusterFromS3RequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterFromS3ResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterFromS3_DBClusterParameterGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterFromS3");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterFromS3Request>();
            var marshaller = new RestoreDBClusterFromS3RequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterParameterGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterFromS3ResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterFromS3_DBClusterQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterFromS3");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterFromS3Request>();
            var marshaller = new RestoreDBClusterFromS3RequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterFromS3ResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterFromS3_DBSubnetGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterFromS3");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterFromS3Request>();
            var marshaller = new RestoreDBClusterFromS3RequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSubnetGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterFromS3ResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterFromS3_DomainNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterFromS3");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterFromS3Request>();
            var marshaller = new RestoreDBClusterFromS3RequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DomainNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterFromS3ResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterFromS3_InsufficientStorageClusterCapacityExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterFromS3");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterFromS3Request>();
            var marshaller = new RestoreDBClusterFromS3RequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientStorageClusterCapacityException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterFromS3ResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterFromS3_InvalidDBClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterFromS3");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterFromS3Request>();
            var marshaller = new RestoreDBClusterFromS3RequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterFromS3ResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterFromS3_InvalidDBSubnetGroupStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterFromS3");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterFromS3Request>();
            var marshaller = new RestoreDBClusterFromS3RequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBSubnetGroupStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterFromS3ResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterFromS3_InvalidS3BucketExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterFromS3");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterFromS3Request>();
            var marshaller = new RestoreDBClusterFromS3RequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidS3BucketException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterFromS3ResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterFromS3_InvalidSubnetExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterFromS3");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterFromS3Request>();
            var marshaller = new RestoreDBClusterFromS3RequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidSubnetException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterFromS3ResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterFromS3_InvalidVPCNetworkStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterFromS3");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterFromS3Request>();
            var marshaller = new RestoreDBClusterFromS3RequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidVPCNetworkStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterFromS3ResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterFromS3_KMSKeyNotAccessibleExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterFromS3");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterFromS3Request>();
            var marshaller = new RestoreDBClusterFromS3RequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("KMSKeyNotAccessibleException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterFromS3ResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterFromS3_StorageQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterFromS3");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterFromS3Request>();
            var marshaller = new RestoreDBClusterFromS3RequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StorageQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterFromS3ResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterFromSnapshotMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterFromSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterFromSnapshotRequest>();
            var marshaller = new RestoreDBClusterFromSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RestoreDBClusterFromSnapshotResponseUnmarshaller.Instance.Unmarshall(context)
                as RestoreDBClusterFromSnapshotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterFromSnapshot_DBClusterAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterFromSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterFromSnapshotRequest>();
            var marshaller = new RestoreDBClusterFromSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterFromSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterFromSnapshot_DBClusterParameterGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterFromSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterFromSnapshotRequest>();
            var marshaller = new RestoreDBClusterFromSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterParameterGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterFromSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterFromSnapshot_DBClusterQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterFromSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterFromSnapshotRequest>();
            var marshaller = new RestoreDBClusterFromSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterFromSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterFromSnapshot_DBClusterSnapshotNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterFromSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterFromSnapshotRequest>();
            var marshaller = new RestoreDBClusterFromSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterSnapshotNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterFromSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterFromSnapshot_DBSnapshotNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterFromSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterFromSnapshotRequest>();
            var marshaller = new RestoreDBClusterFromSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSnapshotNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterFromSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterFromSnapshot_DBSubnetGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterFromSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterFromSnapshotRequest>();
            var marshaller = new RestoreDBClusterFromSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSubnetGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterFromSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterFromSnapshot_DomainNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterFromSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterFromSnapshotRequest>();
            var marshaller = new RestoreDBClusterFromSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DomainNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterFromSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterFromSnapshot_InsufficientDBClusterCapacityExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterFromSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterFromSnapshotRequest>();
            var marshaller = new RestoreDBClusterFromSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientDBClusterCapacityException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterFromSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterFromSnapshot_InsufficientStorageClusterCapacityExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterFromSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterFromSnapshotRequest>();
            var marshaller = new RestoreDBClusterFromSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientStorageClusterCapacityException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterFromSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterFromSnapshot_InvalidDBClusterSnapshotStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterFromSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterFromSnapshotRequest>();
            var marshaller = new RestoreDBClusterFromSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterSnapshotStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterFromSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterFromSnapshot_InvalidDBInstanceStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterFromSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterFromSnapshotRequest>();
            var marshaller = new RestoreDBClusterFromSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBInstanceStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterFromSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterFromSnapshot_InvalidDBSnapshotStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterFromSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterFromSnapshotRequest>();
            var marshaller = new RestoreDBClusterFromSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBSnapshotStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterFromSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterFromSnapshot_InvalidRestoreExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterFromSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterFromSnapshotRequest>();
            var marshaller = new RestoreDBClusterFromSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRestoreException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterFromSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterFromSnapshot_InvalidSubnetExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterFromSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterFromSnapshotRequest>();
            var marshaller = new RestoreDBClusterFromSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidSubnetException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterFromSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterFromSnapshot_InvalidVPCNetworkStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterFromSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterFromSnapshotRequest>();
            var marshaller = new RestoreDBClusterFromSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidVPCNetworkStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterFromSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterFromSnapshot_KMSKeyNotAccessibleExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterFromSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterFromSnapshotRequest>();
            var marshaller = new RestoreDBClusterFromSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("KMSKeyNotAccessibleException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterFromSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterFromSnapshot_OptionGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterFromSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterFromSnapshotRequest>();
            var marshaller = new RestoreDBClusterFromSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OptionGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterFromSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterFromSnapshot_StorageQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterFromSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterFromSnapshotRequest>();
            var marshaller = new RestoreDBClusterFromSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StorageQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterFromSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterToPointInTimeMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterToPointInTimeRequest>();
            var marshaller = new RestoreDBClusterToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RestoreDBClusterToPointInTimeResponseUnmarshaller.Instance.Unmarshall(context)
                as RestoreDBClusterToPointInTimeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterToPointInTime_DBClusterAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterToPointInTimeRequest>();
            var marshaller = new RestoreDBClusterToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterToPointInTime_DBClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterToPointInTimeRequest>();
            var marshaller = new RestoreDBClusterToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterToPointInTime_DBClusterParameterGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterToPointInTimeRequest>();
            var marshaller = new RestoreDBClusterToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterParameterGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterToPointInTime_DBClusterQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterToPointInTimeRequest>();
            var marshaller = new RestoreDBClusterToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterToPointInTime_DBClusterSnapshotNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterToPointInTimeRequest>();
            var marshaller = new RestoreDBClusterToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterSnapshotNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterToPointInTime_DBSubnetGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterToPointInTimeRequest>();
            var marshaller = new RestoreDBClusterToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSubnetGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterToPointInTime_DomainNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterToPointInTimeRequest>();
            var marshaller = new RestoreDBClusterToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DomainNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterToPointInTime_InsufficientDBClusterCapacityExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterToPointInTimeRequest>();
            var marshaller = new RestoreDBClusterToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientDBClusterCapacityException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterToPointInTime_InsufficientStorageClusterCapacityExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterToPointInTimeRequest>();
            var marshaller = new RestoreDBClusterToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientStorageClusterCapacityException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterToPointInTime_InvalidDBClusterSnapshotStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterToPointInTimeRequest>();
            var marshaller = new RestoreDBClusterToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterSnapshotStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterToPointInTime_InvalidDBClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterToPointInTimeRequest>();
            var marshaller = new RestoreDBClusterToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterToPointInTime_InvalidDBSnapshotStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterToPointInTimeRequest>();
            var marshaller = new RestoreDBClusterToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBSnapshotStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterToPointInTime_InvalidRestoreExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterToPointInTimeRequest>();
            var marshaller = new RestoreDBClusterToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRestoreException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterToPointInTime_InvalidSubnetExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterToPointInTimeRequest>();
            var marshaller = new RestoreDBClusterToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidSubnetException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterToPointInTime_InvalidVPCNetworkStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterToPointInTimeRequest>();
            var marshaller = new RestoreDBClusterToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidVPCNetworkStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterToPointInTime_KMSKeyNotAccessibleExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterToPointInTimeRequest>();
            var marshaller = new RestoreDBClusterToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("KMSKeyNotAccessibleException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterToPointInTime_OptionGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterToPointInTimeRequest>();
            var marshaller = new RestoreDBClusterToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OptionGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBClusterToPointInTime_StorageQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterToPointInTimeRequest>();
            var marshaller = new RestoreDBClusterToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StorageQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBClusterToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromDBSnapshotMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromDBSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromDBSnapshotRequest>();
            var marshaller = new RestoreDBInstanceFromDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.Instance.Unmarshall(context)
                as RestoreDBInstanceFromDBSnapshotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromDBSnapshot_AuthorizationNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromDBSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromDBSnapshotRequest>();
            var marshaller = new RestoreDBInstanceFromDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AuthorizationNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromDBSnapshot_BackupPolicyNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromDBSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromDBSnapshotRequest>();
            var marshaller = new RestoreDBInstanceFromDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BackupPolicyNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromDBSnapshot_DBClusterSnapshotNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromDBSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromDBSnapshotRequest>();
            var marshaller = new RestoreDBInstanceFromDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterSnapshotNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromDBSnapshot_DBInstanceAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromDBSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromDBSnapshotRequest>();
            var marshaller = new RestoreDBInstanceFromDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromDBSnapshot_DBParameterGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromDBSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromDBSnapshotRequest>();
            var marshaller = new RestoreDBInstanceFromDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBParameterGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromDBSnapshot_DBSecurityGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromDBSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromDBSnapshotRequest>();
            var marshaller = new RestoreDBInstanceFromDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSecurityGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromDBSnapshot_DBSnapshotNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromDBSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromDBSnapshotRequest>();
            var marshaller = new RestoreDBInstanceFromDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSnapshotNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromDBSnapshot_DBSubnetGroupDoesNotCoverEnoughAZsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromDBSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromDBSnapshotRequest>();
            var marshaller = new RestoreDBInstanceFromDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSubnetGroupDoesNotCoverEnoughAZsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromDBSnapshot_DBSubnetGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromDBSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromDBSnapshotRequest>();
            var marshaller = new RestoreDBInstanceFromDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSubnetGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromDBSnapshot_DomainNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromDBSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromDBSnapshotRequest>();
            var marshaller = new RestoreDBInstanceFromDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DomainNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromDBSnapshot_InstanceQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromDBSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromDBSnapshotRequest>();
            var marshaller = new RestoreDBInstanceFromDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InstanceQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromDBSnapshot_InsufficientDBInstanceCapacityExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromDBSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromDBSnapshotRequest>();
            var marshaller = new RestoreDBInstanceFromDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientDBInstanceCapacityException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromDBSnapshot_InvalidDBSnapshotStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromDBSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromDBSnapshotRequest>();
            var marshaller = new RestoreDBInstanceFromDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBSnapshotStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromDBSnapshot_InvalidRestoreExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromDBSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromDBSnapshotRequest>();
            var marshaller = new RestoreDBInstanceFromDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRestoreException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromDBSnapshot_InvalidSubnetExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromDBSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromDBSnapshotRequest>();
            var marshaller = new RestoreDBInstanceFromDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidSubnetException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromDBSnapshot_InvalidVPCNetworkStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromDBSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromDBSnapshotRequest>();
            var marshaller = new RestoreDBInstanceFromDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidVPCNetworkStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromDBSnapshot_KMSKeyNotAccessibleExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromDBSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromDBSnapshotRequest>();
            var marshaller = new RestoreDBInstanceFromDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("KMSKeyNotAccessibleException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromDBSnapshot_NetworkTypeNotSupportedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromDBSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromDBSnapshotRequest>();
            var marshaller = new RestoreDBInstanceFromDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("NetworkTypeNotSupportedException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromDBSnapshot_OptionGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromDBSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromDBSnapshotRequest>();
            var marshaller = new RestoreDBInstanceFromDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OptionGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromDBSnapshot_ProvisionedIopsNotAvailableInAZExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromDBSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromDBSnapshotRequest>();
            var marshaller = new RestoreDBInstanceFromDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ProvisionedIopsNotAvailableInAZException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromDBSnapshot_StorageQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromDBSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromDBSnapshotRequest>();
            var marshaller = new RestoreDBInstanceFromDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StorageQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromDBSnapshot_StorageTypeNotSupportedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromDBSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromDBSnapshotRequest>();
            var marshaller = new RestoreDBInstanceFromDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StorageTypeNotSupportedException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromS3MarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromS3");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromS3Request>();
            var marshaller = new RestoreDBInstanceFromS3RequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RestoreDBInstanceFromS3ResponseUnmarshaller.Instance.Unmarshall(context)
                as RestoreDBInstanceFromS3Response;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromS3_AuthorizationNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromS3");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromS3Request>();
            var marshaller = new RestoreDBInstanceFromS3RequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AuthorizationNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromS3ResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromS3_BackupPolicyNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromS3");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromS3Request>();
            var marshaller = new RestoreDBInstanceFromS3RequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BackupPolicyNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromS3ResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromS3_DBInstanceAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromS3");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromS3Request>();
            var marshaller = new RestoreDBInstanceFromS3RequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromS3ResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromS3_DBParameterGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromS3");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromS3Request>();
            var marshaller = new RestoreDBInstanceFromS3RequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBParameterGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromS3ResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromS3_DBSecurityGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromS3");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromS3Request>();
            var marshaller = new RestoreDBInstanceFromS3RequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSecurityGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromS3ResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromS3_DBSubnetGroupDoesNotCoverEnoughAZsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromS3");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromS3Request>();
            var marshaller = new RestoreDBInstanceFromS3RequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSubnetGroupDoesNotCoverEnoughAZsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromS3ResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromS3_DBSubnetGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromS3");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromS3Request>();
            var marshaller = new RestoreDBInstanceFromS3RequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSubnetGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromS3ResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromS3_InstanceQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromS3");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromS3Request>();
            var marshaller = new RestoreDBInstanceFromS3RequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InstanceQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromS3ResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromS3_InsufficientDBInstanceCapacityExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromS3");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromS3Request>();
            var marshaller = new RestoreDBInstanceFromS3RequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientDBInstanceCapacityException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromS3ResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromS3_InvalidS3BucketExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromS3");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromS3Request>();
            var marshaller = new RestoreDBInstanceFromS3RequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidS3BucketException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromS3ResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromS3_InvalidSubnetExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromS3");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromS3Request>();
            var marshaller = new RestoreDBInstanceFromS3RequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidSubnetException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromS3ResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromS3_InvalidVPCNetworkStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromS3");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromS3Request>();
            var marshaller = new RestoreDBInstanceFromS3RequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidVPCNetworkStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromS3ResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromS3_KMSKeyNotAccessibleExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromS3");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromS3Request>();
            var marshaller = new RestoreDBInstanceFromS3RequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("KMSKeyNotAccessibleException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromS3ResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromS3_NetworkTypeNotSupportedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromS3");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromS3Request>();
            var marshaller = new RestoreDBInstanceFromS3RequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("NetworkTypeNotSupportedException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromS3ResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromS3_OptionGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromS3");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromS3Request>();
            var marshaller = new RestoreDBInstanceFromS3RequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OptionGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromS3ResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromS3_ProvisionedIopsNotAvailableInAZExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromS3");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromS3Request>();
            var marshaller = new RestoreDBInstanceFromS3RequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ProvisionedIopsNotAvailableInAZException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromS3ResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromS3_StorageQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromS3");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromS3Request>();
            var marshaller = new RestoreDBInstanceFromS3RequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StorageQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromS3ResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromS3_StorageTypeNotSupportedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromS3");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromS3Request>();
            var marshaller = new RestoreDBInstanceFromS3RequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StorageTypeNotSupportedException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceFromS3ResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceToPointInTimeMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceToPointInTimeRequest>();
            var marshaller = new RestoreDBInstanceToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RestoreDBInstanceToPointInTimeResponseUnmarshaller.Instance.Unmarshall(context)
                as RestoreDBInstanceToPointInTimeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceToPointInTime_AuthorizationNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceToPointInTimeRequest>();
            var marshaller = new RestoreDBInstanceToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AuthorizationNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceToPointInTime_BackupPolicyNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceToPointInTimeRequest>();
            var marshaller = new RestoreDBInstanceToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BackupPolicyNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceToPointInTime_DBInstanceAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceToPointInTimeRequest>();
            var marshaller = new RestoreDBInstanceToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceToPointInTime_DBInstanceAutomatedBackupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceToPointInTimeRequest>();
            var marshaller = new RestoreDBInstanceToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceAutomatedBackupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceToPointInTime_DBInstanceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceToPointInTimeRequest>();
            var marshaller = new RestoreDBInstanceToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceToPointInTime_DBParameterGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceToPointInTimeRequest>();
            var marshaller = new RestoreDBInstanceToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBParameterGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceToPointInTime_DBSecurityGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceToPointInTimeRequest>();
            var marshaller = new RestoreDBInstanceToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSecurityGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceToPointInTime_DBSubnetGroupDoesNotCoverEnoughAZsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceToPointInTimeRequest>();
            var marshaller = new RestoreDBInstanceToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSubnetGroupDoesNotCoverEnoughAZsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceToPointInTime_DBSubnetGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceToPointInTimeRequest>();
            var marshaller = new RestoreDBInstanceToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSubnetGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceToPointInTime_DomainNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceToPointInTimeRequest>();
            var marshaller = new RestoreDBInstanceToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DomainNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceToPointInTime_InstanceQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceToPointInTimeRequest>();
            var marshaller = new RestoreDBInstanceToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InstanceQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceToPointInTime_InsufficientDBInstanceCapacityExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceToPointInTimeRequest>();
            var marshaller = new RestoreDBInstanceToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientDBInstanceCapacityException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceToPointInTime_InvalidDBInstanceStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceToPointInTimeRequest>();
            var marshaller = new RestoreDBInstanceToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBInstanceStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceToPointInTime_InvalidRestoreExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceToPointInTimeRequest>();
            var marshaller = new RestoreDBInstanceToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRestoreException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceToPointInTime_InvalidSubnetExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceToPointInTimeRequest>();
            var marshaller = new RestoreDBInstanceToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidSubnetException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceToPointInTime_InvalidVPCNetworkStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceToPointInTimeRequest>();
            var marshaller = new RestoreDBInstanceToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidVPCNetworkStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceToPointInTime_KMSKeyNotAccessibleExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceToPointInTimeRequest>();
            var marshaller = new RestoreDBInstanceToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("KMSKeyNotAccessibleException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceToPointInTime_NetworkTypeNotSupportedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceToPointInTimeRequest>();
            var marshaller = new RestoreDBInstanceToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("NetworkTypeNotSupportedException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceToPointInTime_OptionGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceToPointInTimeRequest>();
            var marshaller = new RestoreDBInstanceToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OptionGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceToPointInTime_PointInTimeRestoreNotEnabledExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceToPointInTimeRequest>();
            var marshaller = new RestoreDBInstanceToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("PointInTimeRestoreNotEnabledException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceToPointInTime_ProvisionedIopsNotAvailableInAZExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceToPointInTimeRequest>();
            var marshaller = new RestoreDBInstanceToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ProvisionedIopsNotAvailableInAZException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceToPointInTime_StorageQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceToPointInTimeRequest>();
            var marshaller = new RestoreDBInstanceToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StorageQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceToPointInTime_StorageTypeNotSupportedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceToPointInTimeRequest>();
            var marshaller = new RestoreDBInstanceToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StorageTypeNotSupportedException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RestoreDBInstanceToPointInTimeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RevokeDBSecurityGroupIngressMarshallTest()
        {
            var operation = service_model.FindOperation("RevokeDBSecurityGroupIngress");

            var request = InstantiateClassGenerator.Execute<RevokeDBSecurityGroupIngressRequest>();
            var marshaller = new RevokeDBSecurityGroupIngressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RevokeDBSecurityGroupIngressResponseUnmarshaller.Instance.Unmarshall(context)
                as RevokeDBSecurityGroupIngressResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RevokeDBSecurityGroupIngress_AuthorizationNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RevokeDBSecurityGroupIngress");

            var request = InstantiateClassGenerator.Execute<RevokeDBSecurityGroupIngressRequest>();
            var marshaller = new RevokeDBSecurityGroupIngressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AuthorizationNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RevokeDBSecurityGroupIngressResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RevokeDBSecurityGroupIngress_DBSecurityGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RevokeDBSecurityGroupIngress");

            var request = InstantiateClassGenerator.Execute<RevokeDBSecurityGroupIngressRequest>();
            var marshaller = new RevokeDBSecurityGroupIngressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSecurityGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RevokeDBSecurityGroupIngressResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RevokeDBSecurityGroupIngress_InvalidDBSecurityGroupStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RevokeDBSecurityGroupIngress");

            var request = InstantiateClassGenerator.Execute<RevokeDBSecurityGroupIngressRequest>();
            var marshaller = new RevokeDBSecurityGroupIngressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBSecurityGroupStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RevokeDBSecurityGroupIngressResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartActivityStreamMarshallTest()
        {
            var operation = service_model.FindOperation("StartActivityStream");

            var request = InstantiateClassGenerator.Execute<StartActivityStreamRequest>();
            var marshaller = new StartActivityStreamRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = StartActivityStreamResponseUnmarshaller.Instance.Unmarshall(context)
                as StartActivityStreamResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartActivityStream_DBClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartActivityStream");

            var request = InstantiateClassGenerator.Execute<StartActivityStreamRequest>();
            var marshaller = new StartActivityStreamRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartActivityStreamResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartActivityStream_DBInstanceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartActivityStream");

            var request = InstantiateClassGenerator.Execute<StartActivityStreamRequest>();
            var marshaller = new StartActivityStreamRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartActivityStreamResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartActivityStream_InvalidDBClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartActivityStream");

            var request = InstantiateClassGenerator.Execute<StartActivityStreamRequest>();
            var marshaller = new StartActivityStreamRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartActivityStreamResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartActivityStream_InvalidDBInstanceStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartActivityStream");

            var request = InstantiateClassGenerator.Execute<StartActivityStreamRequest>();
            var marshaller = new StartActivityStreamRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBInstanceStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartActivityStreamResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartActivityStream_KMSKeyNotAccessibleExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartActivityStream");

            var request = InstantiateClassGenerator.Execute<StartActivityStreamRequest>();
            var marshaller = new StartActivityStreamRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("KMSKeyNotAccessibleException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartActivityStreamResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartActivityStream_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartActivityStream");

            var request = InstantiateClassGenerator.Execute<StartActivityStreamRequest>();
            var marshaller = new StartActivityStreamRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartActivityStreamResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartDBClusterMarshallTest()
        {
            var operation = service_model.FindOperation("StartDBCluster");

            var request = InstantiateClassGenerator.Execute<StartDBClusterRequest>();
            var marshaller = new StartDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = StartDBClusterResponseUnmarshaller.Instance.Unmarshall(context)
                as StartDBClusterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartDBCluster_DBClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartDBCluster");

            var request = InstantiateClassGenerator.Execute<StartDBClusterRequest>();
            var marshaller = new StartDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartDBCluster_InvalidDBClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartDBCluster");

            var request = InstantiateClassGenerator.Execute<StartDBClusterRequest>();
            var marshaller = new StartDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartDBCluster_InvalidDBInstanceStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartDBCluster");

            var request = InstantiateClassGenerator.Execute<StartDBClusterRequest>();
            var marshaller = new StartDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBInstanceStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartDBInstanceMarshallTest()
        {
            var operation = service_model.FindOperation("StartDBInstance");

            var request = InstantiateClassGenerator.Execute<StartDBInstanceRequest>();
            var marshaller = new StartDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = StartDBInstanceResponseUnmarshaller.Instance.Unmarshall(context)
                as StartDBInstanceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartDBInstance_AuthorizationNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartDBInstance");

            var request = InstantiateClassGenerator.Execute<StartDBInstanceRequest>();
            var marshaller = new StartDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AuthorizationNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartDBInstance_DBClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartDBInstance");

            var request = InstantiateClassGenerator.Execute<StartDBInstanceRequest>();
            var marshaller = new StartDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartDBInstance_DBInstanceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartDBInstance");

            var request = InstantiateClassGenerator.Execute<StartDBInstanceRequest>();
            var marshaller = new StartDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartDBInstance_DBSubnetGroupDoesNotCoverEnoughAZsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartDBInstance");

            var request = InstantiateClassGenerator.Execute<StartDBInstanceRequest>();
            var marshaller = new StartDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSubnetGroupDoesNotCoverEnoughAZsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartDBInstance_DBSubnetGroupNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartDBInstance");

            var request = InstantiateClassGenerator.Execute<StartDBInstanceRequest>();
            var marshaller = new StartDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSubnetGroupNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartDBInstance_InsufficientDBInstanceCapacityExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartDBInstance");

            var request = InstantiateClassGenerator.Execute<StartDBInstanceRequest>();
            var marshaller = new StartDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientDBInstanceCapacityException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartDBInstance_InvalidDBClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartDBInstance");

            var request = InstantiateClassGenerator.Execute<StartDBInstanceRequest>();
            var marshaller = new StartDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartDBInstance_InvalidDBInstanceStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartDBInstance");

            var request = InstantiateClassGenerator.Execute<StartDBInstanceRequest>();
            var marshaller = new StartDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBInstanceStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartDBInstance_InvalidSubnetExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartDBInstance");

            var request = InstantiateClassGenerator.Execute<StartDBInstanceRequest>();
            var marshaller = new StartDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidSubnetException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartDBInstance_InvalidVPCNetworkStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartDBInstance");

            var request = InstantiateClassGenerator.Execute<StartDBInstanceRequest>();
            var marshaller = new StartDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidVPCNetworkStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartDBInstance_KMSKeyNotAccessibleExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartDBInstance");

            var request = InstantiateClassGenerator.Execute<StartDBInstanceRequest>();
            var marshaller = new StartDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("KMSKeyNotAccessibleException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartDBInstanceAutomatedBackupsReplicationMarshallTest()
        {
            var operation = service_model.FindOperation("StartDBInstanceAutomatedBackupsReplication");

            var request = InstantiateClassGenerator.Execute<StartDBInstanceAutomatedBackupsReplicationRequest>();
            var marshaller = new StartDBInstanceAutomatedBackupsReplicationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = StartDBInstanceAutomatedBackupsReplicationResponseUnmarshaller.Instance.Unmarshall(context)
                as StartDBInstanceAutomatedBackupsReplicationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartDBInstanceAutomatedBackupsReplication_DBInstanceAutomatedBackupQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartDBInstanceAutomatedBackupsReplication");

            var request = InstantiateClassGenerator.Execute<StartDBInstanceAutomatedBackupsReplicationRequest>();
            var marshaller = new StartDBInstanceAutomatedBackupsReplicationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceAutomatedBackupQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartDBInstanceAutomatedBackupsReplicationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartDBInstanceAutomatedBackupsReplication_DBInstanceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartDBInstanceAutomatedBackupsReplication");

            var request = InstantiateClassGenerator.Execute<StartDBInstanceAutomatedBackupsReplicationRequest>();
            var marshaller = new StartDBInstanceAutomatedBackupsReplicationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartDBInstanceAutomatedBackupsReplicationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartDBInstanceAutomatedBackupsReplication_InvalidDBInstanceStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartDBInstanceAutomatedBackupsReplication");

            var request = InstantiateClassGenerator.Execute<StartDBInstanceAutomatedBackupsReplicationRequest>();
            var marshaller = new StartDBInstanceAutomatedBackupsReplicationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBInstanceStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartDBInstanceAutomatedBackupsReplicationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartDBInstanceAutomatedBackupsReplication_KMSKeyNotAccessibleExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartDBInstanceAutomatedBackupsReplication");

            var request = InstantiateClassGenerator.Execute<StartDBInstanceAutomatedBackupsReplicationRequest>();
            var marshaller = new StartDBInstanceAutomatedBackupsReplicationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("KMSKeyNotAccessibleException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartDBInstanceAutomatedBackupsReplicationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartDBInstanceAutomatedBackupsReplication_StorageTypeNotSupportedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartDBInstanceAutomatedBackupsReplication");

            var request = InstantiateClassGenerator.Execute<StartDBInstanceAutomatedBackupsReplicationRequest>();
            var marshaller = new StartDBInstanceAutomatedBackupsReplicationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("StorageTypeNotSupportedException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartDBInstanceAutomatedBackupsReplicationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartExportTaskMarshallTest()
        {
            var operation = service_model.FindOperation("StartExportTask");

            var request = InstantiateClassGenerator.Execute<StartExportTaskRequest>();
            var marshaller = new StartExportTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = StartExportTaskResponseUnmarshaller.Instance.Unmarshall(context)
                as StartExportTaskResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartExportTask_DBClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartExportTask");

            var request = InstantiateClassGenerator.Execute<StartExportTaskRequest>();
            var marshaller = new StartExportTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartExportTaskResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartExportTask_DBClusterSnapshotNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartExportTask");

            var request = InstantiateClassGenerator.Execute<StartExportTaskRequest>();
            var marshaller = new StartExportTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterSnapshotNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartExportTaskResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartExportTask_DBSnapshotNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartExportTask");

            var request = InstantiateClassGenerator.Execute<StartExportTaskRequest>();
            var marshaller = new StartExportTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSnapshotNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartExportTaskResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartExportTask_ExportTaskAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartExportTask");

            var request = InstantiateClassGenerator.Execute<StartExportTaskRequest>();
            var marshaller = new StartExportTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ExportTaskAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartExportTaskResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartExportTask_IamRoleMissingPermissionsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartExportTask");

            var request = InstantiateClassGenerator.Execute<StartExportTaskRequest>();
            var marshaller = new StartExportTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("IamRoleMissingPermissionsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartExportTaskResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartExportTask_IamRoleNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartExportTask");

            var request = InstantiateClassGenerator.Execute<StartExportTaskRequest>();
            var marshaller = new StartExportTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("IamRoleNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartExportTaskResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartExportTask_InvalidExportOnlyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartExportTask");

            var request = InstantiateClassGenerator.Execute<StartExportTaskRequest>();
            var marshaller = new StartExportTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidExportOnlyException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartExportTaskResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartExportTask_InvalidExportSourceStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartExportTask");

            var request = InstantiateClassGenerator.Execute<StartExportTaskRequest>();
            var marshaller = new StartExportTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidExportSourceStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartExportTaskResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartExportTask_InvalidS3BucketExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartExportTask");

            var request = InstantiateClassGenerator.Execute<StartExportTaskRequest>();
            var marshaller = new StartExportTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidS3BucketException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartExportTaskResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StartExportTask_KMSKeyNotAccessibleExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartExportTask");

            var request = InstantiateClassGenerator.Execute<StartExportTaskRequest>();
            var marshaller = new StartExportTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("KMSKeyNotAccessibleException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartExportTaskResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StopActivityStreamMarshallTest()
        {
            var operation = service_model.FindOperation("StopActivityStream");

            var request = InstantiateClassGenerator.Execute<StopActivityStreamRequest>();
            var marshaller = new StopActivityStreamRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = StopActivityStreamResponseUnmarshaller.Instance.Unmarshall(context)
                as StopActivityStreamResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StopActivityStream_DBClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StopActivityStream");

            var request = InstantiateClassGenerator.Execute<StopActivityStreamRequest>();
            var marshaller = new StopActivityStreamRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StopActivityStreamResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StopActivityStream_DBInstanceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StopActivityStream");

            var request = InstantiateClassGenerator.Execute<StopActivityStreamRequest>();
            var marshaller = new StopActivityStreamRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StopActivityStreamResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StopActivityStream_InvalidDBClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StopActivityStream");

            var request = InstantiateClassGenerator.Execute<StopActivityStreamRequest>();
            var marshaller = new StopActivityStreamRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StopActivityStreamResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StopActivityStream_InvalidDBInstanceStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StopActivityStream");

            var request = InstantiateClassGenerator.Execute<StopActivityStreamRequest>();
            var marshaller = new StopActivityStreamRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBInstanceStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StopActivityStreamResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StopActivityStream_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StopActivityStream");

            var request = InstantiateClassGenerator.Execute<StopActivityStreamRequest>();
            var marshaller = new StopActivityStreamRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StopActivityStreamResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StopDBClusterMarshallTest()
        {
            var operation = service_model.FindOperation("StopDBCluster");

            var request = InstantiateClassGenerator.Execute<StopDBClusterRequest>();
            var marshaller = new StopDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = StopDBClusterResponseUnmarshaller.Instance.Unmarshall(context)
                as StopDBClusterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StopDBCluster_DBClusterNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StopDBCluster");

            var request = InstantiateClassGenerator.Execute<StopDBClusterRequest>();
            var marshaller = new StopDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBClusterNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StopDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StopDBCluster_InvalidDBClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StopDBCluster");

            var request = InstantiateClassGenerator.Execute<StopDBClusterRequest>();
            var marshaller = new StopDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StopDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StopDBCluster_InvalidDBInstanceStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StopDBCluster");

            var request = InstantiateClassGenerator.Execute<StopDBClusterRequest>();
            var marshaller = new StopDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBInstanceStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StopDBClusterResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StopDBInstanceMarshallTest()
        {
            var operation = service_model.FindOperation("StopDBInstance");

            var request = InstantiateClassGenerator.Execute<StopDBInstanceRequest>();
            var marshaller = new StopDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = StopDBInstanceResponseUnmarshaller.Instance.Unmarshall(context)
                as StopDBInstanceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StopDBInstance_DBInstanceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StopDBInstance");

            var request = InstantiateClassGenerator.Execute<StopDBInstanceRequest>();
            var marshaller = new StopDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StopDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StopDBInstance_DBSnapshotAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StopDBInstance");

            var request = InstantiateClassGenerator.Execute<StopDBInstanceRequest>();
            var marshaller = new StopDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBSnapshotAlreadyExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StopDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StopDBInstance_InvalidDBClusterStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StopDBInstance");

            var request = InstantiateClassGenerator.Execute<StopDBInstanceRequest>();
            var marshaller = new StopDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBClusterStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StopDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StopDBInstance_InvalidDBInstanceStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StopDBInstance");

            var request = InstantiateClassGenerator.Execute<StopDBInstanceRequest>();
            var marshaller = new StopDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBInstanceStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StopDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StopDBInstance_SnapshotQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StopDBInstance");

            var request = InstantiateClassGenerator.Execute<StopDBInstanceRequest>();
            var marshaller = new StopDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SnapshotQuotaExceededException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StopDBInstanceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StopDBInstanceAutomatedBackupsReplicationMarshallTest()
        {
            var operation = service_model.FindOperation("StopDBInstanceAutomatedBackupsReplication");

            var request = InstantiateClassGenerator.Execute<StopDBInstanceAutomatedBackupsReplicationRequest>();
            var marshaller = new StopDBInstanceAutomatedBackupsReplicationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = StopDBInstanceAutomatedBackupsReplicationResponseUnmarshaller.Instance.Unmarshall(context)
                as StopDBInstanceAutomatedBackupsReplicationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StopDBInstanceAutomatedBackupsReplication_DBInstanceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StopDBInstanceAutomatedBackupsReplication");

            var request = InstantiateClassGenerator.Execute<StopDBInstanceAutomatedBackupsReplicationRequest>();
            var marshaller = new StopDBInstanceAutomatedBackupsReplicationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StopDBInstanceAutomatedBackupsReplicationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void StopDBInstanceAutomatedBackupsReplication_InvalidDBInstanceStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StopDBInstanceAutomatedBackupsReplication");

            var request = InstantiateClassGenerator.Execute<StopDBInstanceAutomatedBackupsReplicationRequest>();
            var marshaller = new StopDBInstanceAutomatedBackupsReplicationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBInstanceStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StopDBInstanceAutomatedBackupsReplicationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void SwitchoverBlueGreenDeploymentMarshallTest()
        {
            var operation = service_model.FindOperation("SwitchoverBlueGreenDeployment");

            var request = InstantiateClassGenerator.Execute<SwitchoverBlueGreenDeploymentRequest>();
            var marshaller = new SwitchoverBlueGreenDeploymentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = SwitchoverBlueGreenDeploymentResponseUnmarshaller.Instance.Unmarshall(context)
                as SwitchoverBlueGreenDeploymentResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void SwitchoverBlueGreenDeployment_BlueGreenDeploymentNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SwitchoverBlueGreenDeployment");

            var request = InstantiateClassGenerator.Execute<SwitchoverBlueGreenDeploymentRequest>();
            var marshaller = new SwitchoverBlueGreenDeploymentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BlueGreenDeploymentNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = SwitchoverBlueGreenDeploymentResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void SwitchoverBlueGreenDeployment_InvalidBlueGreenDeploymentStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SwitchoverBlueGreenDeployment");

            var request = InstantiateClassGenerator.Execute<SwitchoverBlueGreenDeploymentRequest>();
            var marshaller = new SwitchoverBlueGreenDeploymentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidBlueGreenDeploymentStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = SwitchoverBlueGreenDeploymentResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void SwitchoverReadReplicaMarshallTest()
        {
            var operation = service_model.FindOperation("SwitchoverReadReplica");

            var request = InstantiateClassGenerator.Execute<SwitchoverReadReplicaRequest>();
            var marshaller = new SwitchoverReadReplicaRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = SwitchoverReadReplicaResponseUnmarshaller.Instance.Unmarshall(context)
                as SwitchoverReadReplicaResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void SwitchoverReadReplica_DBInstanceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SwitchoverReadReplica");

            var request = InstantiateClassGenerator.Execute<SwitchoverReadReplicaRequest>();
            var marshaller = new SwitchoverReadReplicaRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DBInstanceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = SwitchoverReadReplicaResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void SwitchoverReadReplica_InvalidDBInstanceStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SwitchoverReadReplica");

            var request = InstantiateClassGenerator.Execute<SwitchoverReadReplicaRequest>();
            var marshaller = new SwitchoverReadReplicaRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDBInstanceStateException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = SwitchoverReadReplicaResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }
    }
}