/*
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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Describes the configuration of a destination in Amazon Redshift.
    /// </summary>
    public partial class RedshiftDestinationConfiguration
    {
        /// <summary>
        /// Gets and sets the property CloudWatchLoggingOptions. 
        /// <para>
        /// The CloudWatch logging options for your Firehose stream.
        /// </para>
        /// </summary>
        public CloudWatchLoggingOptions CloudWatchLoggingOptions { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchLoggingOptions property is set.
        /// </summary>
        internal bool IsSetCloudWatchLoggingOptions() => this.CloudWatchLoggingOptions != null;

        /// <summary>
        /// Gets and sets the property ClusterJDBCURL. 
        /// <para>
        /// The database connection string.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string ClusterJDBCURL { get; set; }

        /// <summary>
        /// Checks to see if the ClusterJDBCURL property is set.
        /// </summary>
        internal bool IsSetClusterJDBCURL() => this.ClusterJDBCURL != null;

        /// <summary>
        /// Gets and sets the property CopyCommand. 
        /// <para>
        /// The <c>COPY</c> command.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CopyCommand CopyCommand { get; set; }

        /// <summary>
        /// Checks to see if the CopyCommand property is set.
        /// </summary>
        internal bool IsSetCopyCommand() => this.CopyCommand != null;

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// The user password.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 6, Max = 512)]
        public string Password { get; set; }

        /// <summary>
        /// Checks to see if the Password property is set.
        /// </summary>
        internal bool IsSetPassword() => this.Password != null;

        /// <summary>
        /// Gets and sets the property ProcessingConfiguration. 
        /// <para>
        /// The data processing configuration.
        /// </para>
        /// </summary>
        public ProcessingConfiguration ProcessingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ProcessingConfiguration property is set.
        /// </summary>
        internal bool IsSetProcessingConfiguration() => this.ProcessingConfiguration != null;

        /// <summary>
        /// Gets and sets the property RetryOptions. 
        /// <para>
        /// The retry behavior in case Firehose is unable to deliver documents to Amazon Redshift.
        /// Default value is 3600 (60 minutes).
        /// </para>
        /// </summary>
        public RedshiftRetryOptions RetryOptions { get; set; }

        /// <summary>
        /// Checks to see if the RetryOptions property is set.
        /// </summary>
        internal bool IsSetRetryOptions() => this.RetryOptions != null;

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services credentials. For more information,
        /// see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and Amazon Web Services Service Namespaces</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string RoleARN { get; set; }

        /// <summary>
        /// Checks to see if the RoleARN property is set.
        /// </summary>
        internal bool IsSetRoleARN() => this.RoleARN != null;

        /// <summary>
        /// Gets and sets the property S3BackupConfiguration. 
        /// <para>
        /// The configuration for backup in Amazon S3.
        /// </para>
        /// </summary>
        public S3DestinationConfiguration S3BackupConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the S3BackupConfiguration property is set.
        /// </summary>
        internal bool IsSetS3BackupConfiguration() => this.S3BackupConfiguration != null;

        /// <summary>
        /// Gets and sets the property S3BackupMode. 
        /// <para>
        /// The Amazon S3 backup mode. After you create a Firehose stream, you can update it to
        /// enable Amazon S3 backup if it is disabled. If backup is enabled, you can't update
        /// the Firehose stream to disable it. 
        /// </para>
        /// </summary>
        public RedshiftS3BackupMode S3BackupMode { get; set; }

        /// <summary>
        /// Checks to see if the S3BackupMode property is set.
        /// </summary>
        internal bool IsSetS3BackupMode() => this.S3BackupMode != null;

        /// <summary>
        /// Gets and sets the property S3Configuration. 
        /// <para>
        /// The configuration for the intermediate Amazon S3 location from which Amazon Redshift
        /// obtains data. Restrictions are described in the topic for <a>CreateDeliveryStream</a>.
        /// </para>
        ///  
        /// <para>
        /// The compression formats <c>SNAPPY</c> or <c>ZIP</c> cannot be specified in <c>RedshiftDestinationConfiguration.S3Configuration</c>
        /// because the Amazon Redshift <c>COPY</c> operation that reads from the S3 bucket doesn't
        /// support these compression formats.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public S3DestinationConfiguration S3Configuration { get; set; }

        /// <summary>
        /// Checks to see if the S3Configuration property is set.
        /// </summary>
        internal bool IsSetS3Configuration() => this.S3Configuration != null;

        /// <summary>
        /// Gets and sets the property SecretsManagerConfiguration. 
        /// <para>
        ///  The configuration that defines how you access secrets for Amazon Redshift. 
        /// </para>
        /// </summary>
        public SecretsManagerConfiguration SecretsManagerConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SecretsManagerConfiguration property is set.
        /// </summary>
        internal bool IsSetSecretsManagerConfiguration() => this.SecretsManagerConfiguration != null;

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 512)]
        public string Username { get; set; }

        /// <summary>
        /// Checks to see if the Username property is set.
        /// </summary>
        internal bool IsSetUsername() => this.Username != null;
    }
}
