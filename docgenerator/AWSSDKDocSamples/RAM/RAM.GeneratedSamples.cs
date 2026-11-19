using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.RAM;
using Amazon.RAM.Model;

namespace AWSSDKDocSamples.Amazon.RAM.Generated
{
    class RAMSamples : ISample
    {
        public void RAMUpdatePermission()
        {
            #region UpdatePermission-1

            var client = new AmazonRAMClient();
            var response = client.UpdatePermission(new UpdatePermissionRequest
            {
                PermissionArn = "arn:aws:ram:us-east-1:123456789012:permission/AnyCompanyImageBuilderPermission",
                Status = "DEPRECATED"
            });

            UpdatePermissionStatus permissionStatus = response.PermissionStatus;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
