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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the StartActivityStream operation.
    /// Starts a database activity stream to monitor activity on the database. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/DBActivityStreams.html">
    /// Monitoring Amazon Aurora with Database Activity Streams</a> in the <i>Amazon Aurora
    /// User Guide</i> or <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/DBActivityStreams.html">
    /// Monitoring Amazon RDS with Database Activity Streams</a> in the <i>Amazon RDS User
    /// Guide</i>.
    /// </summary>
    public partial class StartActivityStreamRequest : AmazonRDSRequest
    {
        private bool? _applyImmediately;
        private bool? _engineNativeAuditFieldsIncluded;
        private string _kmsKeyId;
        private ActivityStreamMode _mode;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property ApplyImmediately. 
        /// <para>
        /// Specifies whether or not the database activity stream is to start as soon as possible,
        /// regardless of the maintenance window for the database.
        /// </para>
        /// </summary>
        public bool ApplyImmediately
        {
            get { return this._applyImmediately.GetValueOrDefault(); }
            set { this._applyImmediately = value; }
        }

        // Check to see if ApplyImmediately property is set
        internal bool IsSetApplyImmediately()
        {
            return this._applyImmediately.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EngineNativeAuditFieldsIncluded. 
        /// <para>
        /// Specifies whether the database activity stream includes engine-native audit fields.
        /// This option only applies to an Oracle DB instance. By default, no engine-native audit
        /// fields are included.
        /// </para>
        /// </summary>
        public bool EngineNativeAuditFieldsIncluded
        {
            get { return this._engineNativeAuditFieldsIncluded.GetValueOrDefault(); }
            set { this._engineNativeAuditFieldsIncluded = value; }
        }

        // Check to see if EngineNativeAuditFieldsIncluded property is set
        internal bool IsSetEngineNativeAuditFieldsIncluded()
        {
            return this._engineNativeAuditFieldsIncluded.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Web Services KMS key identifier for encrypting messages in the database
        /// activity stream. The Amazon Web Services KMS key identifier is the key ARN, key ID,
        /// alias ARN, or alias name for the KMS key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// Specifies the mode of the database activity stream. Database events such as a change
        /// or access generate an activity stream event. The database session can handle these
        /// events either synchronously or asynchronously.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ActivityStreamMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the DB cluster, for example, <code>arn:aws:rds:us-east-1:12345667890:cluster:das-cluster</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}