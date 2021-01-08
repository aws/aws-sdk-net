﻿/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.KinesisVideoArchivedMedia.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.KinesisVideoArchivedMedia
{
    public partial class AmazonKinesisVideoArchivedMediaClient : AmazonServiceClient
    {
        /// <summary>
        /// Constructs AmazonKinesisVideoArchivedMediaClient with the credentials loaded from the application's
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
        /// <param name="serviceUrl">The URL of the search or document service.</param>
        public AmazonKinesisVideoArchivedMediaClient(string serviceUrl)
            : base(FallbackCredentialsFactory.GetCredentials(true), new AmazonKinesisVideoArchivedMediaConfig { ServiceURL = serviceUrl })
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisVideoArchivedMediaClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonKinesisVideoArchivedMediaClient Configuration Object</param>
        public AmazonKinesisVideoArchivedMediaClient(AmazonKinesisVideoArchivedMediaConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(true), config)
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisVideoArchivedMediaClient with AWS Credentials
        /// </summary>
        /// <param name="serviceUrl">The URL of the search or document service.</param>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonKinesisVideoArchivedMediaClient(string serviceUrl, AWSCredentials credentials)
            : this(credentials, new AmazonKinesisVideoArchivedMediaConfig { ServiceURL = serviceUrl })
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisVideoArchivedMediaClient with AWS Credentials and an
        /// AmazonKinesisVideoArchivedMediaClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonKinesisVideoArchivedMediaClient Configuration Object</param>
        public AmazonKinesisVideoArchivedMediaClient(AWSCredentials credentials, AmazonKinesisVideoArchivedMediaConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisVideoArchivedMediaClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="serviceUrl">The URL of the search or document service.</param>
        public AmazonKinesisVideoArchivedMediaClient(string awsAccessKeyId, string awsSecretAccessKey, string serviceUrl)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKinesisVideoArchivedMediaConfig { ServiceURL = serviceUrl })
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisVideoArchivedMediaClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKinesisVideoArchivedMediaClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonKinesisVideoArchivedMediaClient Configuration Object</param>
        public AmazonKinesisVideoArchivedMediaClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonKinesisVideoArchivedMediaConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisVideoArchivedMediaClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="serviceUrl">The URL of the search or document service.</param>
        public AmazonKinesisVideoArchivedMediaClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, string serviceUrl)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKinesisVideoArchivedMediaConfig{ ServiceURL = serviceUrl})
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisVideoArchivedMediaClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKinesisVideoArchivedMediaClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonKinesisVideoArchivedMediaClient Configuration Object</param>
        public AmazonKinesisVideoArchivedMediaClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonKinesisVideoArchivedMediaConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }


    }
}
