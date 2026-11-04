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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the StartActivityStream operation. Starts a database
    /// activity stream to monitor activity on the database. For more information, see <a
    /// href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/DBActivityStreams.html">
    /// Monitoring Amazon Aurora with Database Activity Streams</a> in the <i>Amazon Aurora
    /// User Guide</i> or <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/DBActivityStreams.html">
    /// Monitoring Amazon RDS with Database Activity Streams</a> in the <i>Amazon RDS User
    /// Guide</i>.
    /// </summary>
    public partial class StartActivityStreamRequest : AmazonRDSRequest
    {
        /// <summary>
        /// Gets and sets the property ApplyImmediately. 
        /// <para>
        /// Specifies whether or not the database activity stream is to start as soon as possible,
        /// regardless of the maintenance window for the database.
        /// </para>
        /// </summary>
        public bool? ApplyImmediately { get; set; }

        /// <summary>
        /// Checks to see if the ApplyImmediately property is set.
        /// </summary>
        internal bool IsSetApplyImmediately() => this.ApplyImmediately.HasValue;

        /// <summary>
        /// Gets and sets the property EngineNativeAuditFieldsIncluded. 
        /// <para>
        /// Specifies whether the database activity stream includes engine-native audit fields.
        /// This option applies to an Oracle or Microsoft SQL Server DB instance. By default,
        /// no engine-native audit fields are included.
        /// </para>
        /// </summary>
        public bool? EngineNativeAuditFieldsIncluded { get; set; }

        /// <summary>
        /// Checks to see if the EngineNativeAuditFieldsIncluded property is set.
        /// </summary>
        internal bool IsSetEngineNativeAuditFieldsIncluded() => this.EngineNativeAuditFieldsIncluded.HasValue;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Web Services KMS key identifier for encrypting messages in the database
        /// activity stream. The Amazon Web Services KMS key identifier is the key ARN, key ID,
        /// alias ARN, or alias name for the KMS key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// Specifies the mode of the database activity stream. Database events such as a change
        /// or access generate an activity stream event. The database session can handle these
        /// events either synchronously or asynchronously.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ActivityStreamMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the DB cluster, for example, <c>arn:aws:rds:us-east-1:12345667890:cluster:das-cluster</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;
    }
}
