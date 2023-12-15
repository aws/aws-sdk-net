using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Cloud9;
using Amazon.Cloud9.Model;

namespace AWSSDKDocSamples.Amazon.Cloud9.Generated
{
    class Cloud9Samples : ISample
    {
        public void Cloud9CreateEnvironmentEC2()
        {
            #region createenvironmentec2-1516821730547

            var client = new AmazonCloud9Client();
            var response = client.CreateEnvironmentEC2(new CreateEnvironmentEC2Request 
            {
                Name = "my-demo-environment",
                AutomaticStopTimeMinutes = 60,
                Description = "This is my demonstration environment.",
                ImageId = "amazonlinux-2023-x86_64",
                InstanceType = "t2.micro",
                OwnerArn = "arn:aws:iam::123456789012:user/MyDemoUser",
                SubnetId = "subnet-6300cd1b"
            });

            string environmentId = response.EnvironmentId;

            #endregion
        }

        public void Cloud9CreateEnvironmentMembership()
        {
            #region createenvironmentmembership-1516822583452

            var client = new AmazonCloud9Client();
            var response = client.CreateEnvironmentMembership(new CreateEnvironmentMembershipRequest 
            {
                EnvironmentId = "8d9967e2f0624182b74e7690ad69ebEX",
                Permissions = "read-write",
                UserArn = "arn:aws:iam::123456789012:user/AnotherDemoUser"
            });

            EnvironmentMember membership = response.Membership;

            #endregion
        }

        public void Cloud9DeleteEnvironment()
        {
            #region deleteenvironment-1516822903149

            var client = new AmazonCloud9Client();
            var response = client.DeleteEnvironment(new DeleteEnvironmentRequest 
            {
                EnvironmentId = "8d9967e2f0624182b74e7690ad69ebEX"
            });


            #endregion
        }

        public void Cloud9DeleteEnvironmentMembership()
        {
            #region deleteenvironmentmembership-1516822975655

            var client = new AmazonCloud9Client();
            var response = client.DeleteEnvironmentMembership(new DeleteEnvironmentMembershipRequest 
            {
                EnvironmentId = "8d9967e2f0624182b74e7690ad69ebEX",
                UserArn = "arn:aws:iam::123456789012:user/AnotherDemoUser"
            });


            #endregion
        }

        public void Cloud9DescribeEnvironmentMemberships()
        {
            #region describeenvironmentmemberships1-1516823070453

            var client = new AmazonCloud9Client();
            var response = client.DescribeEnvironmentMemberships(new DescribeEnvironmentMembershipsRequest 
            {
                EnvironmentId = "8d9967e2f0624182b74e7690ad69ebEX"
            });

            List<EnvironmentMember> memberships = response.Memberships;

            #endregion
        }

        public void Cloud9DescribeEnvironmentMemberships()
        {
            #region describeenvironmentmemberships2-1516823191355

            var client = new AmazonCloud9Client();
            var response = client.DescribeEnvironmentMemberships(new DescribeEnvironmentMembershipsRequest 
            {
                EnvironmentId = "8d9967e2f0624182b74e7690ad69ebEX",
                Permissions = new List<string> {
                    "owner"
                }
            });

            List<EnvironmentMember> memberships = response.Memberships;

            #endregion
        }

        public void Cloud9DescribeEnvironmentMemberships()
        {
            #region describeenvironmentmemberships3-1516823268793

            var client = new AmazonCloud9Client();
            var response = client.DescribeEnvironmentMemberships(new DescribeEnvironmentMembershipsRequest 
            {
                UserArn = "arn:aws:iam::123456789012:user/MyDemoUser"
            });

            List<EnvironmentMember> memberships = response.Memberships;

            #endregion
        }

        public void Cloud9DescribeEnvironments()
        {
            #region describeenvironments-1516823568291

            var client = new AmazonCloud9Client();
            var response = client.DescribeEnvironments(new DescribeEnvironmentsRequest 
            {
                EnvironmentIds = new List<string> {
                    "8d9967e2f0624182b74e7690ad69ebEX",
                    "349c86d4579e4e7298d500ff57a6b2EX"
                }
            });

            List<Environment> environments = response.Environments;

            #endregion
        }

        public void Cloud9DescribeEnvironmentStatus()
        {
            #region describeenvironmentstatus-1516823462133

            var client = new AmazonCloud9Client();
            var response = client.DescribeEnvironmentStatus(new DescribeEnvironmentStatusRequest 
            {
                EnvironmentId = "8d9967e2f0624182b74e7690ad69ebEX"
            });

            string message = response.Message;
            string status = response.Status;

            #endregion
        }

        public void Cloud9ListEnvironments()
        {
            #region listenvironments-1516823687205

            var client = new AmazonCloud9Client();
            var response = client.ListEnvironments(new ListEnvironmentsRequest 
            {
            });

            List<string> environmentIds = response.EnvironmentIds;

            #endregion
        }

        public void Cloud9UpdateEnvironment()
        {
            #region updateenvironment-1516823781910

            var client = new AmazonCloud9Client();
            var response = client.UpdateEnvironment(new UpdateEnvironmentRequest 
            {
                Name = "my-changed-demo-environment",
                Description = "This is my changed demonstration environment.",
                EnvironmentId = "8d9967e2f0624182b74e7690ad69ebEX"
            });


            #endregion
        }

        public void Cloud9UpdateEnvironmentMembership()
        {
            #region updateenvironmentmembership-1516823876645

            var client = new AmazonCloud9Client();
            var response = client.UpdateEnvironmentMembership(new UpdateEnvironmentMembershipRequest 
            {
                EnvironmentId = "8d9967e2f0624182b74e7690ad69ebEX",
                Permissions = "read-only",
                UserArn = "arn:aws:iam::123456789012:user/AnotherDemoUser"
            });

            EnvironmentMember membership = response.Membership;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}