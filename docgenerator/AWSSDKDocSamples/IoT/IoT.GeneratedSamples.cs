using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.IoT;
using Amazon.IoT.Model;

namespace AWSSDKDocSamples.Amazon.IoT.Generated
{
    class IoTSamples : ISample
    {
        public void IoTDescribeEncryptionConfiguration()
        {
            #region describeencryptionconfiguration-1752775629029

            var client = new AmazonIoTClient();
            var response = client.DescribeEncryptionConfiguration(new DescribeEncryptionConfigurationRequest 
            {
            });

            ConfigurationDetails configurationDetails = response.ConfigurationDetails;
            string encryptionType = response.EncryptionType;
            string kmsAccessRoleArn = response.KmsAccessRoleArn;
            string kmsKeyArn = response.KmsKeyArn;
            DateTime lastModifiedDate = response.LastModifiedDate;

            #endregion
        }

        public void IoTUpdateEncryptionConfiguration()
        {
            #region updateencryptionconfiguration-example-1749856813098

            var client = new AmazonIoTClient();
            var response = client.UpdateEncryptionConfiguration(new UpdateEncryptionConfigurationRequest 
            {
                EncryptionType = "CUSTOMER_MANAGED_KMS_KEY",
                KmsAccessRoleArn = "arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab",
                KmsKeyArn = "arn:aws:iam:us-west-2:111122223333:role/myrole"
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