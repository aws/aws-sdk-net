using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.EKS;
using Amazon.EKS.Model;

namespace AWSSDKDocSamples.Amazon.EKS.Generated
{
    class EKSSamples : ISample
    {
        static IAmazonEKS client = new AmazonEKSClient();
        public void EKSCreateCluster()
        {
            #region to-create-a-new-cluster-1527868185648

            var response = client.CreateCluster(new CreateClusterRequest 
            {
                Version = "1.10",
                Name = "prod",
                ClientRequestToken = "1d2129a1-3d38-460a-9756-e5b91fddb951",
                ResourcesVpcConfig = new VpcConfigRequest {
                    SecurityGroupIds = new List<string> {
                        "sg-6979fe18"
                    },
                    SubnetIds = new List<string> {
                        "subnet-6782e71e",
                        "subnet-e7e761ac"
                    }
                },
                RoleArn = "arn:aws:iam::012345678910:role/eks-service-role-AWSServiceRoleForAmazonEKS-J7ONKE3BQ4PI"
            });


            #endregion
        }

        public void EKSDeleteCluster()
        {
            #region to-delete-a-cluster-1527868641252

            var response = client.DeleteCluster(new DeleteClusterRequest 
            {
                Name = "devel"
            });


            #endregion
        }

        public void EKSDescribeCluster()
        {
            #region to-describe-a-cluster-1527868708512

            var response = client.DescribeCluster(new DescribeClusterRequest 
            {
                Name = "devel"
            });

            Cluster cluster = response.Cluster;

            #endregion
        }

        public void EKSListClusters()
        {
            #region to-list-your-available-clusters-1527868801040

            var response = client.ListClusters(new ListClustersRequest 
            {
            });

            List<string> clusters = response.Clusters;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}