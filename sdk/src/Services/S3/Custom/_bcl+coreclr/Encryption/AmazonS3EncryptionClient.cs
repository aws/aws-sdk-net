/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.S3.Model;
using Amazon.Util;
using System.Collections.Generic;
using System.Globalization;

namespace Amazon.S3.Encryption
{
    /// <summary>
    /// This class extends the AmazonS3Client and provides client side encryption when reading or writing S3 objects.
    /// </summary>
    public partial class AmazonS3EncryptionClient : AmazonS3Client
    {
        internal EncryptionMaterials EncryptionMaterials
        {
            get;
            private set;
        }


        private AmazonS3Client s3ClientForInstructionFile;
        
        internal AmazonS3Client S3ClientForInstructionFile
	    {
	        get
	        {
	            if (s3ClientForInstructionFile == null)
	            {
                    s3ClientForInstructionFile = new AmazonS3Client(Credentials, S3CryptoConfig);
                }
	            return s3ClientForInstructionFile;
	        }
	    }

        internal AmazonS3CryptoConfiguration S3CryptoConfig
        {
            get;
            private set;
        }

        internal Dictionary<string, UploadPartEncryptionContext> CurrentMultiPartUploadKeys = new Dictionary<string, UploadPartEncryptionContext>();

        internal const string S3CryptoStream = "S3-Crypto-Stream";

        #region Constructors
        /// <summary>
        /// Constructs AmazonS3EncryptionClient with the Encryption materials and credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// 
        /// </summary>
        /// <param name="materials">
        /// The encryption materials to be used to encrypt and decrypt envelope key.
        /// </param>
        public AmazonS3EncryptionClient(EncryptionMaterials materials)
            : base()
        {
            this.EncryptionMaterials = materials;
            S3CryptoConfig = new AmazonS3CryptoConfiguration();
        }

        /// <summary>
        /// Constructs AmazonS3EncryptionClient with the Encryption materials and credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// 
        /// </summary>
        /// <param name="region">
        /// The region to connect.
        /// </param>
        /// <param name="materials">
        /// The encryption materials to be used to encrypt and decrypt envelope key.
        /// </param>
        public AmazonS3EncryptionClient(RegionEndpoint region, EncryptionMaterials materials)
            : base(region)
        {
            this.EncryptionMaterials = materials;  
            S3CryptoConfig = new AmazonS3CryptoConfiguration();
        }

        /// <summary>
        /// Constructs AmazonS3EncryptionClient with the Encryption materials, 
        /// AmazonS3 CryptoConfiguration object and credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// 
        /// </summary>
        /// <param name="config">
        /// The AmazonS3EncryptionClient CryptoConfiguration Object
        /// </param>
        /// <param name="materials">
        /// The encryption materials to be used to encrypt and decrypt envelope key.
        /// </param>
        public AmazonS3EncryptionClient(AmazonS3CryptoConfiguration config, EncryptionMaterials materials)
            : base(config)
        {
            this.EncryptionMaterials = materials; 
            S3CryptoConfig = config;
        }

        /// <summary>
        ///  Constructs AmazonS3EncryptionClient with AWS Credentials and Encryption materials.
        /// </summary>
        /// <param name="materials">
        /// The encryption materials to be used to encrypt and decrypt envelope key.
        /// </param>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonS3EncryptionClient(AWSCredentials credentials, EncryptionMaterials materials)
            : base(credentials)
        {
            this.EncryptionMaterials = materials; 
            S3CryptoConfig = new AmazonS3CryptoConfiguration();
        }

        /// <summary>
        /// Constructs AmazonS3EncryptionClient with AWS Credentials, Region and Encryption materials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        /// <param name="materials">
        /// The encryption materials to be used to encrypt and decrypt envelope key.
        /// </param>
        public AmazonS3EncryptionClient(AWSCredentials credentials, RegionEndpoint region, EncryptionMaterials materials)
            : base(credentials, region)
        {
            this.EncryptionMaterials = materials; 
            S3CryptoConfig = new AmazonS3CryptoConfiguration();
        }

        /// <summary>
        /// Constructs AmazonS3EncryptionClient with AWS Credentials, AmazonS3CryptoConfiguration Configuration object
        /// and Encryption materials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">The AmazonS3EncryptionClient CryptoConfiguration Object</param>
        /// <param name="materials">
        /// The encryption materials to be used to encrypt and decrypt envelope key.
        /// </param>
        public AmazonS3EncryptionClient(AWSCredentials credentials, AmazonS3CryptoConfiguration config, EncryptionMaterials materials)
            : base(credentials, config)
        {
            this.EncryptionMaterials = materials; 
            S3CryptoConfig = config;
        }

        /// <summary>
        /// Constructs AmazonS3EncryptionClient with AWS Access Key ID,
        /// AWS Secret Key and Encryption materials
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="materials">The encryption materials to be used to encrypt and decrypt envelope key.</param>
        public AmazonS3EncryptionClient(string awsAccessKeyId, string awsSecretAccessKey, EncryptionMaterials materials)
            : base(awsAccessKeyId, awsSecretAccessKey)
        {
            this.EncryptionMaterials = materials;
            S3CryptoConfig = new AmazonS3CryptoConfiguration();
        }

        /// <summary>
        /// Constructs AmazonS3EncryptionClient with AWS Access Key ID,
        /// AWS Secret Key, Region and Encryption materials
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        /// <param name="materials">The encryption materials to be used to encrypt and decrypt envelope key.</param>
        public AmazonS3EncryptionClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region, EncryptionMaterials materials)
            : base(awsAccessKeyId, awsSecretAccessKey, region)
        {
            this.EncryptionMaterials = materials; 
            S3CryptoConfig = new AmazonS3CryptoConfiguration();
        }

        /// <summary>
        /// Constructs AmazonS3EncryptionClient with AWS Access Key ID, Secret Key,
        /// AmazonS3 CryptoConfiguration object and Encryption materials.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="config">The AmazonS3EncryptionClient CryptoConfiguration Object</param>
        /// <param name="materials">The encryption materials to be used to encrypt and decrypt envelope key.</param>
        public AmazonS3EncryptionClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonS3CryptoConfiguration config, EncryptionMaterials materials)
            : base(awsAccessKeyId, awsSecretAccessKey, config)
        {
            this.EncryptionMaterials = materials;
            S3CryptoConfig = config;
        }

        /// <summary>
        /// Constructs AmazonS3EncryptionClient with AWS Access Key ID, Secret Key,
        /// SessionToken and Encryption materials.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="materials">
        /// The encryption materials to be used to encrypt and decrypt envelope key.
        /// </param>
        public AmazonS3EncryptionClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, EncryptionMaterials materials)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken)
        {
            this.EncryptionMaterials = materials; 
            S3CryptoConfig = new AmazonS3CryptoConfiguration();
        }

        /// <summary>
        /// Constructs AmazonS3EncryptionClient with AWS Access Key ID, Secret Key,
        ///  SessionToken, Region and Encryption materials.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        /// <param name="materials">The encryption materials to be used to encrypt and decrypt envelope key.</param>
        public AmazonS3EncryptionClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region, EncryptionMaterials materials)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, region)
        {
            this.EncryptionMaterials = materials; 
            S3CryptoConfig = new AmazonS3CryptoConfiguration();
        }

        /// <summary>
        /// Constructs AmazonS3EncryptionClient with AWS Access Key ID, Secret Key, SessionToken
        /// AmazonS3EncryptionClient CryptoConfiguration object and Encryption materials.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="config">The AmazonS3EncryptionClient CryptoConfiguration Object</param>
        /// <param name="materials">
        /// The encryption materials to be used to encrypt and decrypt envelope key.
        /// </param>
        public AmazonS3EncryptionClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonS3CryptoConfiguration config, EncryptionMaterials materials)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, config)
        {
            this.EncryptionMaterials = materials; 
            S3CryptoConfig = config;
        }        

        #endregion


        /// <summary>
        /// Turn off response logging because it will interfere with decrypt of the data coming back from S3.
        /// </summary>
        protected override bool SupportResponseLogging
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Customize the pipeline to allow encryption.
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            base.CustomizeRuntimePipeline(pipeline);

            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Marshaller>(new Amazon.S3.Encryption.Internal.SetupEncryptionHandler(this));
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new Amazon.S3.Encryption.Internal.UserAgentHandler());
            pipeline.AddHandlerBefore<Amazon.S3.Internal.AmazonS3ResponseHandler>(new Amazon.S3.Encryption.Internal.SetupDecryptionHandler(this));
        }  
    }
}
