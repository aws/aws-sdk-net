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

namespace Amazon.DocDB.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyDBInstance operation. Modifies settings
    /// for an instance. You can change one or more database configuration parameters by specifying
    /// these parameters and the new values in the request.
    /// </summary>
    public partial class ModifyDBInstanceRequest : AmazonDocDBRequest
    {
        /// <summary>
        /// Gets and sets the property ApplyImmediately. 
        /// <para>
        /// Specifies whether the modifications in this request and any pending modifications
        /// are asynchronously applied as soon as possible, regardless of the <c>PreferredMaintenanceWindow</c>
        /// setting for the instance. 
        /// </para>
        ///  
        /// <para>
        ///  If this parameter is set to <c>false</c>, changes to the instance are applied during
        /// the next maintenance window. Some parameter changes can cause an outage and are applied
        /// on the next reboot.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>false</c> 
        /// </para>
        /// </summary>
        public bool? ApplyImmediately { get; set; }

        /// <summary>
        /// Checks to see if the ApplyImmediately property is set.
        /// </summary>
        internal bool IsSetApplyImmediately() => this.ApplyImmediately.HasValue;

        /// <summary>
        /// Gets and sets the property AutoMinorVersionUpgrade. 
        /// <para>
        /// This parameter does not apply to Amazon DocumentDB. Amazon DocumentDB does not perform
        /// minor version upgrades regardless of the value set.
        /// </para>
        /// </summary>
        public bool? AutoMinorVersionUpgrade { get; set; }

        /// <summary>
        /// Checks to see if the AutoMinorVersionUpgrade property is set.
        /// </summary>
        internal bool IsSetAutoMinorVersionUpgrade() => this.AutoMinorVersionUpgrade.HasValue;

        /// <summary>
        /// Gets and sets the property CACertificateIdentifier. 
        /// <para>
        /// Indicates the certificate that needs to be associated with the instance.
        /// </para>
        /// </summary>
        public string CACertificateIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the CACertificateIdentifier property is set.
        /// </summary>
        internal bool IsSetCACertificateIdentifier() => this.CACertificateIdentifier != null;

        /// <summary>
        /// Gets and sets the property CertificateRotationRestart. 
        /// <para>
        /// Specifies whether the DB instance is restarted when you rotate your SSL/TLS certificate.
        /// </para>
        ///  
        /// <para>
        /// By default, the DB instance is restarted when you rotate your SSL/TLS certificate.
        /// The certificate is not updated until the DB instance is restarted.
        /// </para>
        ///  <important> 
        /// <para>
        /// Set this parameter only if you are <i>not</i> using SSL/TLS to connect to the DB instance.
        /// </para>
        ///  </important> 
        /// <para>
        /// If you are using SSL/TLS to connect to the DB instance, see <a href="https://docs.aws.amazon.com/documentdb/latest/devguide/ca_cert_rotation.html">Updating
        /// Your Amazon DocumentDB TLS Certificates</a> and <a href="https://docs.aws.amazon.com/documentdb/latest/devguide/security.encryption.ssl.html">
        /// Encrypting Data in Transit</a> in the <i>Amazon DocumentDB Developer Guide</i>.
        /// </para>
        /// </summary>
        public bool? CertificateRotationRestart { get; set; }

        /// <summary>
        /// Checks to see if the CertificateRotationRestart property is set.
        /// </summary>
        internal bool IsSetCertificateRotationRestart() => this.CertificateRotationRestart.HasValue;

        /// <summary>
        /// Gets and sets the property CopyTagsToSnapshot. 
        /// <para>
        /// A value that indicates whether to copy all tags from the DB instance to snapshots
        /// of the DB instance. By default, tags are not copied.
        /// </para>
        /// </summary>
        public bool? CopyTagsToSnapshot { get; set; }

        /// <summary>
        /// Checks to see if the CopyTagsToSnapshot property is set.
        /// </summary>
        internal bool IsSetCopyTagsToSnapshot() => this.CopyTagsToSnapshot.HasValue;

        /// <summary>
        /// Gets and sets the property DBInstanceClass. 
        /// <para>
        /// The new compute and memory capacity of the instance; for example, <c>db.r5.large</c>.
        /// Not all instance classes are available in all Amazon Web Services Regions. 
        /// </para>
        ///  
        /// <para>
        /// If you modify the instance class, an outage occurs during the change. The change is
        /// applied during the next maintenance window, unless <c>ApplyImmediately</c> is specified
        /// as <c>true</c> for this request. 
        /// </para>
        ///  
        /// <para>
        /// Default: Uses existing setting.
        /// </para>
        /// </summary>
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// Checks to see if the DBInstanceClass property is set.
        /// </summary>
        internal bool IsSetDBInstanceClass() => this.DBInstanceClass != null;

        /// <summary>
        /// Gets and sets the property DBInstanceIdentifier. 
        /// <para>
        /// The instance identifier. This value is stored as a lowercase string.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match the identifier of an existing <c>DBInstance</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DBInstanceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBInstanceIdentifier property is set.
        /// </summary>
        internal bool IsSetDBInstanceIdentifier() => this.DBInstanceIdentifier != null;

        /// <summary>
        /// Gets and sets the property EnablePerformanceInsights. 
        /// <para>
        /// A value that indicates whether to enable Performance Insights for the DB Instance.
        /// For more information, see <a href="https://docs.aws.amazon.com/documentdb/latest/devguide/performance-insights.html">Using
        /// Amazon Performance Insights</a>.
        /// </para>
        /// </summary>
        public bool? EnablePerformanceInsights { get; set; }

        /// <summary>
        /// Checks to see if the EnablePerformanceInsights property is set.
        /// </summary>
        internal bool IsSetEnablePerformanceInsights() => this.EnablePerformanceInsights.HasValue;

        /// <summary>
        /// Gets and sets the property NewDBInstanceIdentifier. 
        /// <para>
        ///  The new instance identifier for the instance when renaming an instance. When you
        /// change the instance identifier, an instance reboot occurs immediately if you set <c>Apply
        /// Immediately</c> to <c>true</c>. It occurs during the next maintenance window if you
        /// set <c>Apply Immediately</c> to <c>false</c>. This value is stored as a lowercase
        /// string. 
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
        public string NewDBInstanceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the NewDBInstanceIdentifier property is set.
        /// </summary>
        internal bool IsSetNewDBInstanceIdentifier() => this.NewDBInstanceIdentifier != null;

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
        public string PerformanceInsightsKMSKeyId { get; set; }

        /// <summary>
        /// Checks to see if the PerformanceInsightsKMSKeyId property is set.
        /// </summary>
        internal bool IsSetPerformanceInsightsKMSKeyId() => this.PerformanceInsightsKMSKeyId != null;

        /// <summary>
        /// Gets and sets the property PreferredMaintenanceWindow. 
        /// <para>
        /// The weekly time range (in UTC) during which system maintenance can occur, which might
        /// result in an outage. Changing this parameter doesn't result in an outage except in
        /// the following situation, and the change is asynchronously applied as soon as possible.
        /// If there are pending actions that cause a reboot, and the maintenance window is changed
        /// to include the current time, changing this parameter causes a reboot of the instance.
        /// If you are moving this window to the current time, there must be at least 30 minutes
        /// between the current time and end of the window to ensure that pending changes are
        /// applied.
        /// </para>
        ///  
        /// <para>
        /// Default: Uses existing setting.
        /// </para>
        ///  
        /// <para>
        /// Format: <c>ddd:hh24:mi-ddd:hh24:mi</c> 
        /// </para>
        ///  
        /// <para>
        /// Valid days: Mon, Tue, Wed, Thu, Fri, Sat, Sun
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must be at least 30 minutes.
        /// </para>
        /// </summary>
        public string PreferredMaintenanceWindow { get; set; }

        /// <summary>
        /// Checks to see if the PreferredMaintenanceWindow property is set.
        /// </summary>
        internal bool IsSetPreferredMaintenanceWindow() => this.PreferredMaintenanceWindow != null;

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
        public int? PromotionTier { get; set; }

        /// <summary>
        /// Checks to see if the PromotionTier property is set.
        /// </summary>
        internal bool IsSetPromotionTier() => this.PromotionTier.HasValue;
    }
}
