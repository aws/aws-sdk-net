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
        public void ServiceDiscoveryCreateHttpNamespace()
        {
            #region createhttpnamespace-example-1590114811304

            var client = new AmazonServiceDiscoveryClient();
            var response = client.CreateHttpNamespace(new CreateHttpNamespaceRequest 
            {
                CreatorRequestId = "example-creator-request-id-0001",
                Description = "Example.com AWS Cloud Map HTTP Namespace",
                Name = "example-http.com"
            });

            string operationId = response.OperationId;

            #endregion
        }

        public void ServiceDiscoveryCreatePrivateDnsNamespace()
        {
            #region example-create-private-dns-namespace-1587058592930

            var client = new AmazonServiceDiscoveryClient();
            var response = client.CreatePrivateDnsNamespace(new CreatePrivateDnsNamespaceRequest 
            {
                CreatorRequestId = "eedd6892-50f3-41b2-8af9-611d6e1d1a8c",
                Name = "example.com",
                Vpc = "vpc-1c56417b"
            });

            string operationId = response.OperationId;

            #endregion
        }

        public void ServiceDiscoveryCreatePublicDnsNamespace()
        {
            #region createpublicdnsnamespace-example-1590114940910

            var client = new AmazonServiceDiscoveryClient();
            var response = client.CreatePublicDnsNamespace(new CreatePublicDnsNamespaceRequest 
            {
                CreatorRequestId = "example-creator-request-id-0003",
                Description = "Example.com AWS Cloud Map Public DNS Namespace",
                Name = "example-public-dns.com"
            });

            string operationId = response.OperationId;

            #endregion
        }

        public void ServiceDiscoveryCreateService()
        {
            #region example-create-service-1587235913584

            var client = new AmazonServiceDiscoveryClient();
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

        public void ServiceDiscoveryCreateService()
        {
            #region example-create-service-namespace-arn-1692720000000

            var client = new AmazonServiceDiscoveryClient();
            var response = client.CreateService(new CreateServiceRequest 
            {
                Description = "Example service using namespace ARN",
                DnsConfig = new DnsConfig {
                    DnsRecords = new List<DnsRecord> {
                        new DnsRecord {
                            TTL = 300,
                            Type = "A"
                        }
                    },
                    RoutingPolicy = "MULTIVALUE"
                },
                Name = "example-service",
                NamespaceId = "arn:aws:servicediscovery:us-west-2:123456789012:namespace/ns-abcd1234xmpl5678"
            });

            Service service = response.Service;

            #endregion
        }

        public void ServiceDiscoveryDeleteNamespace()
        {
            #region example-delete-namespace-1587416093508

            var client = new AmazonServiceDiscoveryClient();
            var response = client.DeleteNamespace(new DeleteNamespaceRequest 
            {
                Id = "ns-ylexjili4cdxy3xm"
            });

            string operationId = response.OperationId;

            #endregion
        }

        public void ServiceDiscoveryDeleteNamespace()
        {
            #region example-delete-namespace-arn-1692720000000

            var client = new AmazonServiceDiscoveryClient();
            var response = client.DeleteNamespace(new DeleteNamespaceRequest 
            {
                Id = "arn:aws:servicediscovery:us-west-2:123456789012:namespace/ns-abcd1234xmpl5678"
            });

            string operationId = response.OperationId;

            #endregion
        }

        public void ServiceDiscoveryDeleteService()
        {
            #region example-delete-service-1587416462902

            var client = new AmazonServiceDiscoveryClient();
            var response = client.DeleteService(new DeleteServiceRequest 
            {
                Id = "srv-p5zdwlg5uvvzjita"
            });


            #endregion
        }

        public void ServiceDiscoveryDeleteService()
        {
            #region example-delete-service-arn-1692720000000

            var client = new AmazonServiceDiscoveryClient();
            var response = client.DeleteService(new DeleteServiceRequest 
            {
                Id = "arn:aws:servicediscovery:us-west-2:123456789012:service/srv-abcd1234xmpl5678"
            });


            #endregion
        }

        public void ServiceDiscoveryDeleteServiceAttributes()
        {
            #region example-delete-service-attributes-1587416462902

            var client = new AmazonServiceDiscoveryClient();
            var response = client.DeleteServiceAttributes(new DeleteServiceAttributesRequest 
            {
                Attributes = new List<string> {
                    "port"
                },
                ServiceId = "srv-e4anhexample0004"
            });


            #endregion
        }

        public void ServiceDiscoveryDeleteServiceAttributes()
        {
            #region example-delete-service-attributes-arn-1692720000000

            var client = new AmazonServiceDiscoveryClient();
            var response = client.DeleteServiceAttributes(new DeleteServiceAttributesRequest 
            {
                Attributes = new List<string> {
                    "Port"
                },
                ServiceId = "arn:aws:servicediscovery:us-west-2:123456789012:service/srv-abcd1234xmpl5678"
            });


            #endregion
        }

        public void ServiceDiscoveryDeregisterInstance()
        {
            #region example-deregister-a-service-instance-1587416305738

            var client = new AmazonServiceDiscoveryClient();
            var response = client.DeregisterInstance(new DeregisterInstanceRequest 
            {
                InstanceId = "myservice-53",
                ServiceId = "srv-p5zdwlg5uvvzjita"
            });

            string operationId = response.OperationId;

            #endregion
        }

        public void ServiceDiscoveryDeregisterInstance()
        {
            #region example-deregister-instance-arn-1692720000000

            var client = new AmazonServiceDiscoveryClient();
            var response = client.DeregisterInstance(new DeregisterInstanceRequest 
            {
                InstanceId = "i-abcd1234xmpl5678",
                ServiceId = "arn:aws:servicediscovery:us-west-2:123456789012:service/srv-abcd1234xmpl5678"
            });

            string operationId = response.OperationId;

            #endregion
        }

        public void ServiceDiscoveryDiscoverInstances()
        {
            #region example-discover-registered-instances-1587236343568

            var client = new AmazonServiceDiscoveryClient();
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

        public void ServiceDiscoveryDiscoverInstances()
        {
            #region discover-instances-owner-account-1692720000000

            var client = new AmazonServiceDiscoveryClient();
            var response = client.DiscoverInstances(new DiscoverInstancesRequest 
            {
                NamespaceName = "example-shared-namespace",
                OwnerAccount = "123456789012",
                ServiceName = "shared-namespace-service"
            });

            List<HttpInstanceSummary> instances = response.Instances;

            #endregion
        }

        public void ServiceDiscoveryDiscoverInstancesRevision()
        {
            #region to-discover-the-revision-for-a-registered-instance-1712867460953

            var client = new AmazonServiceDiscoveryClient();
            var response = client.DiscoverInstancesRevision(new DiscoverInstancesRevisionRequest 
            {
                NamespaceName = "example-namespace",
                ServiceName = "example-service"
            });

            long instancesRevision = response.InstancesRevision;

            #endregion
        }

        public void ServiceDiscoveryDiscoverInstancesRevision()
        {
            #region discover-instances-revision-owner-account-1692720000000

            var client = new AmazonServiceDiscoveryClient();
            var response = client.DiscoverInstancesRevision(new DiscoverInstancesRevisionRequest 
            {
                NamespaceName = "example-shared-namespace",
                OwnerAccount = "123456789012",
                ServiceName = "shared-service"
            });

            long instancesRevision = response.InstancesRevision;

            #endregion
        }

        public void ServiceDiscoveryGetInstance()
        {
            #region getinstance-example-1590115065598

            var client = new AmazonServiceDiscoveryClient();
            var response = client.GetInstance(new GetInstanceRequest 
            {
                InstanceId = "i-abcd1234",
                ServiceId = "srv-e4anhexample0004"
            });

            Instance instance = response.Instance;
            string resourceOwner = response.ResourceOwner;

            #endregion
        }

        public void ServiceDiscoveryGetInstance()
        {
            #region getinstance-shared-namespace-1642680000000

            var client = new AmazonServiceDiscoveryClient();
            var response = client.GetInstance(new GetInstanceRequest 
            {
                InstanceId = "i-abcd1234",
                ServiceId = "arn:aws:servicediscovery:us-west-2:123456789012:service/srv-e4anhexample0004"
            });

            Instance instance = response.Instance;
            string resourceOwner = response.ResourceOwner;

            #endregion
        }

        public void ServiceDiscoveryGetInstancesHealthStatus()
        {
            #region getinstanceshealthstatus-example-1590115176146

            var client = new AmazonServiceDiscoveryClient();
            var response = client.GetInstancesHealthStatus(new GetInstancesHealthStatusRequest 
            {
                ServiceId = "srv-e4anhexample0004"
            });

            Dictionary<string, string> status = response.Status;

            #endregion
        }

        public void ServiceDiscoveryGetInstancesHealthStatus()
        {
            #region getinstanceshealthstatus-shared-namespace-1642680000000

            var client = new AmazonServiceDiscoveryClient();
            var response = client.GetInstancesHealthStatus(new GetInstancesHealthStatusRequest 
            {
                ServiceId = "arn:aws:servicediscovery:us-west-2:123456789012:service/srv-e4anhexample0004"
            });

            Dictionary<string, string> status = response.Status;

            #endregion
        }

        public void ServiceDiscoveryGetNamespace()
        {
            #region getnamespace-example-1590115383708

            var client = new AmazonServiceDiscoveryClient();
            var response = client.GetNamespace(new GetNamespaceRequest 
            {
                Id = "ns-e4anhexample0004"
            });

            Namespace awsNamespace = response.Namespace;

            #endregion
        }

        public void ServiceDiscoveryGetNamespace()
        {
            #region get-namespace-arn-1692720000000

            var client = new AmazonServiceDiscoveryClient();
            var response = client.GetNamespace(new GetNamespaceRequest 
            {
                Id = "arn:aws:servicediscovery:us-west-2:123456789012:namespace/ns-abcd1234xmpl5678"
            });

            Namespace awsNamespace = response.Namespace;

            #endregion
        }

        public void ServiceDiscoveryGetOperation()
        {
            #region example-get-operation-result-1587073807124

            var client = new AmazonServiceDiscoveryClient();
            var response = client.GetOperation(new GetOperationRequest 
            {
                OperationId = "gv4g5meo7ndmeh4fqskygvk23d2fijwa-k9302yzd"
            });

            Operation operation = response.Operation;

            #endregion
        }

        public void ServiceDiscoveryGetOperation()
        {
            #region get-operation-owner-account-1692720000000

            var client = new AmazonServiceDiscoveryClient();
            var response = client.GetOperation(new GetOperationRequest 
            {
                OperationId = "abcd1234-xmpl-5678-9012-abcd1234xmpl",
                OwnerAccount = "123456789012"
            });

            Operation operation = response.Operation;

            #endregion
        }

        public void ServiceDiscoveryGetService()
        {
            #region getservice-example-1590117234294

            var client = new AmazonServiceDiscoveryClient();
            var response = client.GetService(new GetServiceRequest 
            {
                Id = "srv-e4anhexample0004"
            });

            Service service = response.Service;

            #endregion
        }

        public void ServiceDiscoveryGetService()
        {
            #region get-service-arn-1692720000000

            var client = new AmazonServiceDiscoveryClient();
            var response = client.GetService(new GetServiceRequest 
            {
                Id = "arn:aws:servicediscovery:us-west-2:123456789012:service/srv-abcd1234xmpl5678"
            });

            Service service = response.Service;

            #endregion
        }

        public void ServiceDiscoveryGetServiceAttributes()
        {
            #region get-service-attributes-example-1590117234294

            var client = new AmazonServiceDiscoveryClient();
            var response = client.GetServiceAttributes(new GetServiceAttributesRequest 
            {
                ServiceId = "srv-e4anhexample0004"
            });

            ServiceAttributes serviceAttributes = response.ServiceAttributes;

            #endregion
        }

        public void ServiceDiscoveryGetServiceAttributes()
        {
            #region get-service-attributes-arn-1692720000000

            var client = new AmazonServiceDiscoveryClient();
            var response = client.GetServiceAttributes(new GetServiceAttributesRequest 
            {
                ServiceId = "arn:aws:servicediscovery:us-west-2:123456789012:service/srv-abcd1234xmpl5678"
            });

            ServiceAttributes serviceAttributes = response.ServiceAttributes;

            #endregion
        }

        public void ServiceDiscoveryListInstances()
        {
            #region example-list-service-instances-1587236237008

            var client = new AmazonServiceDiscoveryClient();
            var response = client.ListInstances(new ListInstancesRequest 
            {
                ServiceId = "srv-qzpwvt2tfqcegapy"
            });

            List<InstanceSummary> instances = response.Instances;

            #endregion
        }

        public void ServiceDiscoveryListInstances()
        {
            #region listinstances-shared-namespace-1642680000000

            var client = new AmazonServiceDiscoveryClient();
            var response = client.ListInstances(new ListInstancesRequest 
            {
                ServiceId = "arn:aws:servicediscovery:us-west-2:123456789012:service/srv-e4anhexample0004"
            });

            List<InstanceSummary> instances = response.Instances;
            string resourceOwner = response.ResourceOwner;

            #endregion
        }

        public void ServiceDiscoveryListNamespaces()
        {
            #region example-list-namespaces-1587401553154

            var client = new AmazonServiceDiscoveryClient();
            var response = client.ListNamespaces(new ListNamespacesRequest 
            {
            });

            List<NamespaceSummary> namespaces = response.Namespaces;

            #endregion
        }

        public void ServiceDiscoveryListNamespaces()
        {
            #region list-namespaces-resource-owner-1642089600000

            var client = new AmazonServiceDiscoveryClient();
            var response = client.ListNamespaces(new ListNamespacesRequest 
            {
                Filters = new List<NamespaceFilter> {
                    new NamespaceFilter {
                        Name = "RESOURCE_OWNER",
                        Values = new List<string> {
                            "OTHER_ACCOUNTS"
                        }
                    }
                }
            });

            List<NamespaceSummary> namespaces = response.Namespaces;

            #endregion
        }

        public void ServiceDiscoveryListOperations()
        {
            #region listoperations-example-1590117354396

            var client = new AmazonServiceDiscoveryClient();
            var response = client.ListOperations(new ListOperationsRequest 
            {
                Filters = new List<OperationFilter> {
                    new OperationFilter {
                        Condition = "IN",
                        Name = "STATUS",
                        Values = new List<string> {
                            "PENDING",
                            "SUCCESS"
                        }
                    }
                }
            });

            List<OperationSummary> operations = response.Operations;

            #endregion
        }

        public void ServiceDiscoveryListServices()
        {
            #region example-list-services-1587236889840

            var client = new AmazonServiceDiscoveryClient();
            var response = client.ListServices(new ListServicesRequest 
            {
            });

            List<ServiceSummary> services = response.Services;

            #endregion
        }

        public void ServiceDiscoveryListServices()
        {
            #region list-services-resource-owner-1692720000000

            var client = new AmazonServiceDiscoveryClient();
            var response = client.ListServices(new ListServicesRequest 
            {
                Filters = new List<ServiceFilter> {
                    new ServiceFilter {
                        Condition = "EQ",
                        Name = "RESOURCE_OWNER",
                        Values = new List<string> {
                            "OTHER_ACCOUNTS"
                        }
                    }
                }
            });

            List<ServiceSummary> services = response.Services;

            #endregion
        }

        public void ServiceDiscoveryListTagsForResource()
        {
            #region listtagsforresource-example-1590093928416

            var client = new AmazonServiceDiscoveryClient();
            var response = client.ListTagsForResource(new ListTagsForResourceRequest 
            {
                ResourceARN = "arn:aws:servicediscovery:us-east-1:123456789012:namespace/ns-ylexjili4cdxy3xm"
            });

            List<Tag> tags = response.Tags;

            #endregion
        }

        public void ServiceDiscoveryRegisterInstance()
        {
            #region example-register-instance-1587236116314

            var client = new AmazonServiceDiscoveryClient();
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

        public void ServiceDiscoveryRegisterInstance()
        {
            #region register-instance-arn-1692720000000

            var client = new AmazonServiceDiscoveryClient();
            var response = client.RegisterInstance(new RegisterInstanceRequest 
            {
                Attributes = new Dictionary<string, string> {
                    { "AWS_INSTANCE_IPV4", "192.0.2.44" },
                    { "AWS_INSTANCE_PORT", "80" }
                },
                InstanceId = "i-abcd1234xmpl5678",
                ServiceId = "arn:aws:servicediscovery:us-west-2:123456789012:service/srv-abcd1234xmpl5678"
            });

            string operationId = response.OperationId;

            #endregion
        }

        public void ServiceDiscoveryTagResource()
        {
            #region tagresource-example-1590093532240

            var client = new AmazonServiceDiscoveryClient();
            var response = client.TagResource(new TagResourceRequest 
            {
                ResourceARN = "arn:aws:servicediscovery:us-east-1:123456789012:namespace/ns-ylexjili4cdxy3xm",
                Tags = new List<Tag> {
                    new Tag {
                        Key = "Department",
                        Value = "Engineering"
                    },
                    new Tag {
                        Key = "Project",
                        Value = "Zeta"
                    }
                }
            });


            #endregion
        }

        public void ServiceDiscoveryUntagResource()
        {
            #region untagresource-example-1590094024672

            var client = new AmazonServiceDiscoveryClient();
            var response = client.UntagResource(new UntagResourceRequest 
            {
                ResourceARN = "arn:aws:servicediscovery:us-east-1:123456789012:namespace/ns-ylexjili4cdxy3xm",
                TagKeys = new List<string> {
                    "Project",
                    "Department"
                }
            });


            #endregion
        }

        public void ServiceDiscoveryUpdateHttpNamespace()
        {
            #region to-update-a-http-namespace-17128EXAMPLE

            var client = new AmazonServiceDiscoveryClient();
            var response = client.UpdateHttpNamespace(new UpdateHttpNamespaceRequest 
            {
                Id = "ns-vh4nbmEXAMPLE",
                Namespace = new HttpNamespaceChange { Description = "The updated namespace description." }
            });

            string operationId = response.OperationId;

            #endregion
        }

        public void ServiceDiscoveryUpdateHttpNamespace()
        {
            #region updatehttpnamespace-shared-namespace-1642680000000

            var client = new AmazonServiceDiscoveryClient();
            var response = client.UpdateHttpNamespace(new UpdateHttpNamespaceRequest 
            {
                Id = "arn:aws:servicediscovery:us-west-2:123456789012:namespace/ns-vh4nbmexample",
                Namespace = new HttpNamespaceChange { Description = "Updated description for shared HTTP namespace." }
            });

            string operationId = response.OperationId;

            #endregion
        }

        public void ServiceDiscoveryUpdateInstanceCustomHealthStatus()
        {
            #region updateinstancecustomhealthstatus-example-1590118408574

            var client = new AmazonServiceDiscoveryClient();
            var response = client.UpdateInstanceCustomHealthStatus(new UpdateInstanceCustomHealthStatusRequest 
            {
                InstanceId = "i-abcd1234",
                ServiceId = "srv-e4anhexample0004",
                Status = "HEALTHY"
            });


            #endregion
        }

        public void ServiceDiscoveryUpdateInstanceCustomHealthStatus()
        {
            #region update-instance-custom-health-status-arn-1692720000000

            var client = new AmazonServiceDiscoveryClient();
            var response = client.UpdateInstanceCustomHealthStatus(new UpdateInstanceCustomHealthStatusRequest 
            {
                InstanceId = "i-abcd1234xmpl5678",
                ServiceId = "arn:aws:servicediscovery:us-west-2:123456789012:service/srv-abcd1234xmpl5678",
                Status = "HEALTHY"
            });


            #endregion
        }

        public void ServiceDiscoveryUpdatePrivateDnsNamespace()
        {
            #region to-update-a-private-dns-namespace-1712868389604

            var client = new AmazonServiceDiscoveryClient();
            var response = client.UpdatePrivateDnsNamespace(new UpdatePrivateDnsNamespaceRequest 
            {
                Id = "ns-bk3aEXAMPLE",
                Namespace = new PrivateDnsNamespaceChange { Description = "The updated namespace description." },
                UpdaterRequestId = ""
            });

            string operationId = response.OperationId;

            #endregion
        }

        public void ServiceDiscoveryUpdatePrivateDnsNamespace()
        {
            #region updateprivatednsnamespace-shared-namespace-1642680000000

            var client = new AmazonServiceDiscoveryClient();
            var response = client.UpdatePrivateDnsNamespace(new UpdatePrivateDnsNamespaceRequest 
            {
                Id = "arn:aws:servicediscovery:us-west-2:123456789012:namespace/ns-bk3aexample",
                Namespace = new PrivateDnsNamespaceChange { Description = "Updated description for shared private DNS namespace." }
            });

            string operationId = response.OperationId;

            #endregion
        }

        public void ServiceDiscoveryUpdatePublicDnsNamespace()
        {
            #region to-update-a-public-dns-namespace-1712868389604

            var client = new AmazonServiceDiscoveryClient();
            var response = client.UpdatePublicDnsNamespace(new UpdatePublicDnsNamespaceRequest 
            {
                Id = "ns-bk3aEXAMPLE",
                Namespace = new PublicDnsNamespaceChange { Description = "The updated namespace description." },
                UpdaterRequestId = ""
            });

            string operationId = response.OperationId;

            #endregion
        }

        public void ServiceDiscoveryUpdatePublicDnsNamespace()
        {
            #region updatepublicdnsnamespace-shared-namespace-1642680000000

            var client = new AmazonServiceDiscoveryClient();
            var response = client.UpdatePublicDnsNamespace(new UpdatePublicDnsNamespaceRequest 
            {
                Id = "arn:aws:servicediscovery:us-west-2:123456789012:namespace/ns-bk3aexample",
                Namespace = new PublicDnsNamespaceChange { Description = "Updated description for shared public DNS namespace." }
            });

            string operationId = response.OperationId;

            #endregion
        }

        public void ServiceDiscoveryUpdateService()
        {
            #region updateservice-example-1590117830880

            var client = new AmazonServiceDiscoveryClient();
            var response = client.UpdateService(new UpdateServiceRequest 
            {
                Id = "srv-e4anhexample0004",
                Service = new ServiceChange {
                    DnsConfig = new DnsConfigChange { DnsRecords = new List<DnsRecord> {
                        new DnsRecord {
                            TTL = 60,
                            Type = "A"
                        }
                    } },
                    HealthCheckConfig = new HealthCheckConfig {
                        FailureThreshold = 2,
                        ResourcePath = "/",
                        Type = "HTTP"
                    }
                }
            });

            string operationId = response.OperationId;

            #endregion
        }

        public void ServiceDiscoveryUpdateService()
        {
            #region updateservice-shared-namespace-1642680000000

            var client = new AmazonServiceDiscoveryClient();
            var response = client.UpdateService(new UpdateServiceRequest 
            {
                Id = "arn:aws:servicediscovery:us-west-2:123456789012:service/srv-e4anhexample0004",
                Service = new ServiceChange { Description = "Updated service description for shared namespace" }
            });

            string operationId = response.OperationId;

            #endregion
        }

        public void ServiceDiscoveryUpdateServiceAttributes()
        {
            #region update-service-attributes-example-1590117830880

            var client = new AmazonServiceDiscoveryClient();
            var response = client.UpdateServiceAttributes(new UpdateServiceAttributesRequest 
            {
                Attributes = new Dictionary<string, string> {
                    { "port", "80" }
                },
                ServiceId = "srv-e4anhexample0004"
            });


            #endregion
        }

        public void ServiceDiscoveryUpdateServiceAttributes()
        {
            #region update-service-attributes-arn-1692720000000

            var client = new AmazonServiceDiscoveryClient();
            var response = client.UpdateServiceAttributes(new UpdateServiceAttributesRequest 
            {
                Attributes = new Dictionary<string, string> {
                    { "Port", "8080" },
                    { "Protocol", "HTTP" }
                },
                ServiceId = "arn:aws:servicediscovery:us-west-2:123456789012:service/srv-abcd1234xmpl5678"
            });


            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}