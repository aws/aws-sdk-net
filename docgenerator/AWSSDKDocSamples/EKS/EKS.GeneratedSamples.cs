using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.EKS;
using Amazon.EKS.Model;

namespace AWSSDKDocSamples.Amazon.EKS.Generated
{
    class EKSSamples : ISample
    {
        public void EKSCreateCluster()
        {
            #region CreateCluster-1

            var client = new AmazonEKSClient();
            var response = client.CreateCluster(new CreateClusterRequest
            {
                ClientRequestToken = "1d2129a1-3d38-460a-9756-e5b91fddb951",
                Name = "prod",
                ResourcesVpcConfig = new VpcConfigRequest {
                    SecurityGroupIds = new List<string> {
                        "sg-6979fe18"
                    },
                    SubnetIds = new List<string> {
                        "subnet-6782e71e",
                        "subnet-e7e761ac"
                    }
                },
                RoleArn = "arn:aws:iam::012345678910:role/eks-service-role-AWSServiceRoleForAmazonEKS-J7ONKE3BQ4PI",
                Version = "1.10"
            });


            #endregion
        }

        public void EKSDeleteCluster()
        {
            #region DeleteCluster-1

            var client = new AmazonEKSClient();
            var response = client.DeleteCluster(new DeleteClusterRequest
            {
                Name = "devel"
            });


            #endregion
        }

        public void EKSDescribeCluster()
        {
            #region DescribeCluster-1

            var client = new AmazonEKSClient();
            var response = client.DescribeCluster(new DescribeClusterRequest
            {
                Name = "devel"
            });

            Cluster cluster = response.Cluster;

            #endregion
        }

        public void EKSListClusters()
        {
            #region ListClusters-1

            var client = new AmazonEKSClient();
            var response = client.ListClusters(new ListClustersRequest
            {
            });

            List<string> clusters = response.Clusters;

            #endregion
        }

        public void EKSListTagsForResource()
        {
            #region ListTagsForResource-1

            var client = new AmazonEKSClient();
            var response = client.ListTagsForResource(new ListTagsForResourceRequest
            {
                ResourceArn = "arn:aws:eks:us-west-2:012345678910:cluster/beta"
            });

            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
