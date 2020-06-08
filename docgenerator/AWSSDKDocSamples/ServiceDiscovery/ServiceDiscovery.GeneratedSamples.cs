using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.ServiceDiscovery;
using Amazon.ServiceDiscovery.Model;

namespace AWSSDKDocSamples.Amazon.ServiceDiscovery.Generated
{
    class ServiceDiscoverySamples : ISample
    {
        static IAmazonServiceDiscovery client = new AmazonServiceDiscoveryClient();
        public void ServiceDiscoveryCreatePrivateDnsNamespace()
        {
            #region example-create-private-dns-namespace-1587058592930

            var response = client.CreatePrivateDnsNamespace(new CreatePrivateDnsNamespaceRequest 
            {
                CreatorRequestId = "eedd6892-50f3-41b2-8af9-611d6e1d1a8c",
                Name = "example.com",
                Vpc = "vpc-1c56417b"
            });

            string operationId = response.OperationId;

            #endregion
        }

        public void ServiceDiscoveryCreateService()
        {
            #region example-create-service-1587235913584

            var response = client.CreateService(new CreateServiceRequest 
            {
                CreatorRequestId = "567c1193-6b00-4308-bd57-ad38a8822d25",
                DnsConfig = new DnsConfig {
                    DnsRecords = new List<DnsRecord> {
                        new DnsRecord {
                            TTL = 60,
                            Type = "A"
                        }
                    },
                    NamespaceId = "ns-ylexjili4cdxy3xm",
                    RoutingPolicy = "MULTIVALUE"
                },
                Name = "myservice",
                NamespaceId = "ns-ylexjili4cdxy3xm"
            });

            Service service = response.Service;

            #endregion
        }

        public void ServiceDiscoveryDeleteNamespace()
        {
            #region example-delete-namespace-1587416093508

            var response = client.DeleteNamespace(new DeleteNamespaceRequest 
            {
                Id = "ns-ylexjili4cdxy3xm"
            });

            string operationId = response.OperationId;

            #endregion
        }

        public void ServiceDiscoveryDeleteService()
        {
            #region example-delete-service-1587416462902

            var response = client.DeleteService(new DeleteServiceRequest 
            {
                Id = "srv-p5zdwlg5uvvzjita"
            });


            #endregion
        }

        public void ServiceDiscoveryDeregisterInstance()
        {
            #region example-deregister-a-service-instance-1587416305738

            var response = client.DeregisterInstance(new DeregisterInstanceRequest 
            {
                InstanceId = "myservice-53",
                ServiceId = "srv-p5zdwlg5uvvzjita"
            });

            string operationId = response.OperationId;

            #endregion
        }

        public void ServiceDiscoveryDiscoverInstances()
        {
            #region example-discover-registered-instances-1587236343568

            var response = client.DiscoverInstances(new DiscoverInstancesRequest 
            {
                HealthStatus = "ALL",
                MaxResults = 10,
                NamespaceName = "example.com",
                ServiceName = "myservice"
            });

            List<HttpInstanceSummary> instances = response.Instances;

            #endregion
        }

        public void ServiceDiscoveryGetOperation()
        {
            #region example-get-operation-result-1587073807124

            var response = client.GetOperation(new GetOperationRequest 
            {
                OperationId = "gv4g5meo7ndmeh4fqskygvk23d2fijwa-k9302yzd"
            });

            Operation operation = response.Operation;

            #endregion
        }

        public void ServiceDiscoveryListInstances()
        {
            #region example-list-service-instances-1587236237008

            var response = client.ListInstances(new ListInstancesRequest 
            {
                ServiceId = "srv-qzpwvt2tfqcegapy"
            });

            List<InstanceSummary> instances = response.Instances;

            #endregion
        }

        public void ServiceDiscoveryListNamespaces()
        {
            #region example-list-namespaces-1587401553154

            var response = client.ListNamespaces(new ListNamespacesRequest 
            {
            });

            List<NamespaceSummary> namespaces = response.Namespaces;

            #endregion
        }

        public void ServiceDiscoveryListServices()
        {
            #region example-list-services-1587236889840

            var response = client.ListServices(new ListServicesRequest 
            {
            });

            List<ServiceSummary> services = response.Services;

            #endregion
        }

        public void ServiceDiscoveryRegisterInstance()
        {
            #region example-register-instance-1587236116314

            var response = client.RegisterInstance(new RegisterInstanceRequest 
            {
                Attributes = new Dictionary<string, string> {
                    { "AWS_INSTANCE_IPV4", "172.2.1.3" },
                    { "AWS_INSTANCE_PORT", "808" }
                },
                CreatorRequestId = "7a48a98a-72e6-4849-bfa7-1a458e030d7b",
                InstanceId = "myservice-53",
                ServiceId = "srv-p5zdwlg5uvvzjita"
            });

            string operationId = response.OperationId;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}