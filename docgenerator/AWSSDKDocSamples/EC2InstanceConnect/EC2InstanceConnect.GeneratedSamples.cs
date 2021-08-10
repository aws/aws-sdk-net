using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.EC2InstanceConnect;
using Amazon.EC2InstanceConnect.Model;

namespace AWSSDKDocSamples.Amazon.EC2InstanceConnect.Generated
{
    class EC2InstanceConnectSamples : ISample
    {
        public void EC2InstanceConnectSendSSHPublicKey()
        {
            #region send-ssh-key-to-an-ec2-instance-1518124883100

            var client = new AmazonEC2InstanceConnectClient();
            var response = client.SendSSHPublicKey(new SendSSHPublicKeyRequest 
            {
                AvailabilityZone = "us-west-2a", // The zone where the instance was launched
                InstanceId = "i-abcd1234", // The instance ID to publish the key to.
                InstanceOSUser = "ec2-user", // This should be the user you wish to be when ssh-ing to the instance (eg, ec2-user@[instance IP])
                SSHPublicKey = "ssh-rsa AAAAB3NzaC1yc2EAAAADAQABAAABAQC3FlHqj2eqCdrGHuA6dRjfZXQ4HX5lXEIRHaNbxEwE5Te7xNF7StwhrDtiV7IdT5fDqbRyGw/szPj3xGkNTVoElCZ2dDFb2qYZ1WLIpZwj/UhO9l2mgfjR56UojjQut5Jvn2KZ1OcyrNO0J83kCaJCV7JoVbXY79FBMUccYNY45zmv9+1FMCfY6i2jdIhwR6+yLk8oubL8lIPyq7X+6b9S0yKCkB7Peml1DvghlybpAIUrC9vofHt6XP4V1i0bImw1IlljQS+DUmULRFSccATDscCX9ajnj7Crhm0HAZC0tBPXpFdHkPwL3yzYo546SCS9LKEwz62ymxxbL9k7h09t" // This should be in standard OpenSSH format (ssh-rsa [key body])
            });

            string requestId = response.RequestId; // This request ID should be provided when contacting AWS Support.
            bool success = response.Success; // Should be true if the service does not return an error response.

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}