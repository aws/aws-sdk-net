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
 * Do not modify this file. This file is generated from the docdb-2014-10-31.normal.json service model.
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
namespace Amazon.DocDB.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDBInstance operation.
    /// Creates a new instance.
    /// </summary>
    public partial class CreateDBInstanceRequest : AmazonDocDBRequest
    {
        private bool? _autoMinorVersionUpgrade;
        private string _availabilityZone;
        private string _caCertificateIdentifier;
        private bool? _copyTagsToSnapshot;
        private string _dbClusterIdentifier;
        private string _dbInstanceClass;
        private string _dbInstanceIdentifier;
        private bool? _enablePerformanceInsights;
        private string _engine;
        private string _performanceInsightsKMSKeyId;
        private string _preferredMaintenanceWindow;
        private int? _promotionTier;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AutoMinorVersionUpgrade. 
        /// <para>
        /// This parameter does not apply to Amazon DocumentDB. Amazon DocumentDB does not perform
        /// minor version upgrades regardless of the value set.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>false</c> 
        /// </para>
        /// </summary>
        public bool? AutoMinorVersionUpgrade
        {
            get { return this._autoMinorVersionUpgrade; }
            set { this._autoMinorVersionUpgrade = value; }
        }

        // Check to see if AutoMinorVersionUpgrade property is set
        internal bool IsSetAutoMinorVersionUpgrade()
        {
            return this._autoMinorVersionUpgrade.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Amazon EC2 Availability Zone that the instance is created in. 
        /// </para>
        ///  
        /// <para>
        /// Default: A random, system-chosen Availability Zone in the endpoint's Amazon Web Services
        /// Region.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>us-east-1d</c> 
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property CACertificateIdentifier. 
        /// <para>
        /// The CA certificate identifier to use for the DB instance's server certificate.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/documentdb/latest/developerguide/ca_cert_rotation.html">Updating
        /// Your Amazon DocumentDB TLS Certificates</a> and <a href="https://docs.aws.amazon.com/documentdb/latest/developerguide/security.encryption.ssl.html">
        /// Encrypting Data in Transit</a> in the <i>Amazon DocumentDB Developer Guide</i>.
        /// </para>
        /// </summary>
        public string CACertificateIdentifier
        {
            get { return this._caCertificateIdentifier; }
            set { this._caCertificateIdentifier = value; }
        }

        // Check to see if CACertificateIdentifier property is set
        internal bool IsSetCACertificateIdentifier()
        {
            return this._caCertificateIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property CopyTagsToSnapshot. 
        /// <para>
        /// A value that indicates whether to copy tags from the DB instance to snapshots of the
        /// DB instance. By default, tags are not copied.
        /// </para>
        /// </summary>
        public bool? CopyTagsToSnapshot
        {
            get { return this._copyTagsToSnapshot; }
            set { this._copyTagsToSnapshot = value; }
        }

        // Check to see if CopyTagsToSnapshot property is set
        internal bool IsSetCopyTagsToSnapshot()
        {
            return this._copyTagsToSnapshot.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// The identifier of the cluster that the instance will belong to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DBClusterIdentifier
        {
            get { return this._dbClusterIdentifier; }
            set { this._dbClusterIdentifier = value; }
        }

        // Check to see if DBClusterIdentifier property is set
        internal bool IsSetDBClusterIdentifier()
        {
            return this._dbClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DBInstanceClass. 
        /// <para>
        /// The compute and memory capacity of the instance; for example, <c>db.r5.large</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DBInstanceClass
        {
            get { return this._dbInstanceClass; }
            set { this._dbInstanceClass = value; }
        }

        // Check to see if DBInstanceClass property is set
        internal bool IsSetDBInstanceClass()
        {
            return this._dbInstanceClass != null;
        }

        /// <summary>
        /// Gets and sets the property DBInstanceIdentifier. 
        /// <para>
        /// The instance identifier. This parameter is stored as a lowercase string.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain from 1 to 63 letters, numbers, or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The first character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot end with a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>mydbinstance</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DBInstanceIdentifier
        {
            get { return this._dbInstanceIdentifier; }
            set { this._dbInstanceIdentifier = value; }
        }

        // Check to see if DBInstanceIdentifier property is set
        internal bool IsSetDBInstanceIdentifier()
        {
            return this._dbInstanceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EnablePerformanceInsights. 
        /// <para>
        /// A value that indicates whether to enable Performance Insights for the DB Instance.
        /// For more information, see <a href="https://docs.aws.amazon.com/documentdb/latest/developerguide/performance-insights.html">Using
        /// Amazon Performance Insights</a>.
        /// </para>
        /// </summary>
        public bool? EnablePerformanceInsights
        {
            get { return this._enablePerformanceInsights; }
            set { this._enablePerformanceInsights = value; }
        }

        // Check to see if EnablePerformanceInsights property is set
        internal bool IsSetEnablePerformanceInsights()
        {
            return this._enablePerformanceInsights.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The name of the database engine to be used for this instance.
        /// </para>
        ///  
        /// <para>
        /// Valid value: <c>docdb</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property PerformanceInsightsKMSKeyId. 
        /// <para>
        /// The KMS key identifier for encryption of Performance Insights data.
        /// </para>
        ///  
        /// <para>
        /// The KMS key identifier is the key ARN, key ID, alias ARN, or alias name for the KMS
        /// key.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify a value for PerformanceInsightsKMSKeyId, then Amazon DocumentDB
        /// uses your default KMS key. There is a default KMS key for your Amazon Web Services
        /// account. Your Amazon Web Services account has a different default KMS key for each
        /// Amazon Web Services region.
        /// </para>
        /// </summary>
        public string PerformanceInsightsKMSKeyId
        {
            get { return this._performanceInsightsKMSKeyId; }
            set { this._performanceInsightsKMSKeyId = value; }
        }

        // Check to see if PerformanceInsightsKMSKeyId property is set
        internal bool IsSetPerformanceInsightsKMSKeyId()
        {
            return this._performanceInsightsKMSKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property PreferredMaintenanceWindow. 
        /// <para>
        /// The time range each week during which system maintenance can occur, in Universal Coordinated
        /// Time (UTC).
        /// </para>
        ///  
        /// <para>
        ///  Format: <c>ddd:hh24:mi-ddd:hh24:mi</c> 
        /// </para>
        ///  
        /// <para>
        /// The default is a 30-minute window selected at random from an 8-hour block of time
        /// for each Amazon Web Services Region, occurring on a random day of the week. 
        /// </para>
        ///  
        /// <para>
        /// Valid days: Mon, Tue, Wed, Thu, Fri, Sat, Sun
        /// </para>
        ///  
        /// <para>
        /// Constraints: Minimum 30-minute window.
        /// </para>
        /// </summary>
        public string PreferredMaintenanceWindow
        {
            get { return this._preferredMaintenanceWindow; }
            set { this._preferredMaintenanceWindow = value; }
        }

        // Check to see if PreferredMaintenanceWindow property is set
        internal bool IsSetPreferredMaintenanceWindow()
        {
            return this._preferredMaintenanceWindow != null;
        }

        /// <summary>
        /// Gets and sets the property PromotionTier. 
        /// <para>
        /// A value that specifies the order in which an Amazon DocumentDB replica is promoted
        /// to the primary instance after a failure of the existing primary instance.
        /// </para>
        ///  
        /// <para>
        /// Default: 1
        /// </para>
        ///  
        /// <para>
        /// Valid values: 0-15
        /// </para>
        /// </summary>
        public int? PromotionTier
        {
            get { return this._promotionTier; }
            set { this._promotionTier = value; }
        }

        // Check to see if PromotionTier property is set
        internal bool IsSetPromotionTier()
        {
            return this._promotionTier.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to be assigned to the instance. You can assign up to 10 tags to an instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}