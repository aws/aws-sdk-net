using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.DSQL;
using Amazon.DSQL.Model;

namespace AWSSDKDocSamples.Amazon.DSQL.Generated
{
    class DSQLSamples : ISample
    {
        public void DSQLCreateCluster()
        {
            #region CreateCluster-1

            var client = new AmazonDSQLClient();
            var response = client.CreateCluster(new CreateClusterRequest
            {
                DeletionProtectionEnabled = false,
                Tags = new Dictionary<string, string> {
                    { "MyKey", "MyValue" }
                }
            });


            #endregion
        }

        public void DSQLDeleteCluster()
        {
            #region DeleteCluster-1

            var client = new AmazonDSQLClient();
            var response = client.DeleteCluster(new DeleteClusterRequest
            {
                Identifier = "kiqenqglxyl2snyvkvnj2c3s2e"
            });


            #endregion
        }

        public void DSQLGetCluster()
        {
            #region GetCluster-1

            var client = new AmazonDSQLClient();
            var response = client.GetCluster(new GetClusterRequest
            {
                Identifier = "kiqenqglxyl2snyvkvnj2c3s2e"
            });


            #endregion
        }

        public void DSQLGetVpcEndpointServiceName()
        {
            #region GetVpcEndpointServiceName-1

            var client = new AmazonDSQLClient();
            var response = client.GetVpcEndpointServiceName(new GetVpcEndpointServiceNameRequest
            {
                Identifier = "kiqenqglxyl2snyvkvnj2c3s2e"
            });


            #endregion
        }

        public void DSQLListClusters()
        {
            #region ListClusters-1

            var client = new AmazonDSQLClient();
            var response = client.ListClusters(new ListClustersRequest
            {
                MaxResults = 20
            });


            #endregion
        }

        public void DSQLListTagsForResource()
        {
            #region ListTagsForResource-1

            var client = new AmazonDSQLClient();
            var response = client.ListTagsForResource(new ListTagsForResourceRequest
            {
                ResourceArn = "arn:aws:dsql:us-east-1:111111222222:cluster/kiqenqglxyl2snyvkvnj2c3s2e"
            });


            #endregion
        }

        public void DSQLTagResource()
        {
            #region TagResource-1

            var client = new AmazonDSQLClient();
            var response = client.TagResource(new TagResourceRequest
            {
                ResourceArn = "arn:aws:dsql:us-east-1:111111222222:cluster/kiqenqglxyl2snyvkvnj2c3s2e",
                Tags = new Dictionary<string, string> {
                    { "MyKey", "MyValue" }
                }
            });


            #endregion
        }

        public void DSQLUntagResource()
        {
            #region UntagResource-1

            var client = new AmazonDSQLClient();
            var response = client.UntagResource(new UntagResourceRequest
            {
                ResourceArn = "arn:aws:dsql:us-east-1:111111222222:cluster/kiqenqglxyl2snyvkvnj2c3s2e",
                TagKeys = new List<string> {
                    "MyKeyA",
                    "MyKeyB"
                }
            });


            #endregion
        }

        public void DSQLUpdateCluster()
        {
            #region UpdateCluster-1

            var client = new AmazonDSQLClient();
            var response = client.UpdateCluster(new UpdateClusterRequest
            {
                DeletionProtectionEnabled = false,
                Identifier = "kiqenqglxyl2snyvkvnj2c3s2e"
            });


            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
