using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.DocDBElastic;
using Amazon.DocDBElastic.Model;

namespace AWSSDKDocSamples.Amazon.DocDBElastic.Generated
{
    class DocDBElasticSamples : ISample
    {
        public void DocDBElasticCopyClusterSnapshot()
        {
            #region CopyClusterSnapshot-1

            var client = new AmazonDocDBElasticClient();
            var response = client.CopyClusterSnapshot(new CopyClusterSnapshotRequest
            {
                SnapshotArn = "arn:aws:docdb-elastic:us-east-1:$AWS_ACCOUNT_ID:cluster-snapshot/$SOURCE_SNAPSHOT_ID",
                TargetSnapshotName = "sampleSnapshotName"
            });

            ClusterSnapshot snapshot = response.Snapshot;

            #endregion
        }

        public void DocDBElasticStartCluster()
        {
            #region StartCluster-1

            var client = new AmazonDocDBElasticClient();
            var response = client.StartCluster(new StartClusterRequest
            {
                ClusterArn = "arn:aws:docdb-elastic:us-east-1:$AWS_ACCOUNT_ID:cluster/$CLUSTER_ID"
            });

            Cluster cluster = response.Cluster;

            #endregion
        }

        public void DocDBElasticStopCluster()
        {
            #region StopCluster-1

            var client = new AmazonDocDBElasticClient();
            var response = client.StopCluster(new StopClusterRequest
            {
                ClusterArn = "arn:aws:docdb-elastic:us-east-1:$AWS_ACCOUNT_ID:cluster/$CLUSTER_ID"
            });

            Cluster cluster = response.Cluster;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
