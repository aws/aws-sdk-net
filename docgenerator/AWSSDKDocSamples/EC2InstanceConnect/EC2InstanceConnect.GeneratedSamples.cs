using System;
using System.Collections.Generic;
using System.IO;
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
            #region SendSSHPublicKey-1

            var client = new AmazonEC2InstanceConnectClient();
            var response = client.SendSSHPublicKey(new SendSSHPublicKeyRequest
            {
                AvailabilityZone = "us-west-2a",
                InstanceId = "i-abcd1234",
                InstanceOSUser = "ec2-user",
                SSHPublicKey = "ssh-rsa AAAAB3NzaC1yc2EAAAADAQABAAABAQC3FlHqj2eqCdrGHuA6dRjfZXQ4HX5lXEIRHaNbxEwE5Te7xNF7StwhrDtiV7IdT5fDqbRyGw/szPj3xGkNTVoElCZ2dDFb2qYZ1WLIpZwj/UhO9l2mgfjR56UojjQut5Jvn2KZ1OcyrNO0J83kCaJCV7JoVbXY79FBMUccYNY45zmv9+1FMCfY6i2jdIhwR6+yLk8oubL8lIPyq7X+6b9S0yKCkB7Peml1DvghlybpAIUrC9vofHt6XP4V1i0bImw1IlljQS+DUmULRFSccATDscCX9ajnj7Crhm0HAZC0tBPXpFdHkPwL3yzYo546SCS9LKEwz62ymxxbL9k7h09t"
            });

            string requestId = response.RequestId;
            bool? success = response.Success;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
