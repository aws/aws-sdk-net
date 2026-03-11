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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the synchronization status of the Amazon Simple Storage Service (Amazon
    /// S3) account-level block public access (BPA) feature for your Lightsail buckets.
    /// 
    ///  
    /// <para>
    /// The account-level BPA feature of Amazon S3 provides centralized controls to limit
    /// public access to all Amazon S3 buckets in an account. BPA can make all Amazon S3 buckets
    /// in an Amazon Web Services account private regardless of the individual bucket and
    /// object permissions that are configured. Lightsail buckets take into account the Amazon
    /// S3 account-level BPA configuration when allowing or denying public access. To do this,
    /// Lightsail periodically fetches the account-level BPA configuration from Amazon S3.
    /// When the account-level BPA status is <c>InSync</c>, the Amazon S3 account-level BPA
    /// configuration is synchronized and it applies to your Lightsail buckets. For more information
    /// about Amazon Simple Storage Service account-level BPA and how it affects Lightsail
    /// buckets, see <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-block-public-access-for-buckets">Block
    /// public access for buckets in Amazon Lightsail</a> in the <i>Amazon Lightsail Developer
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class AccountLevelBpaSync
    {
        private bool? _bpaImpactsLightsail;
        private DateTime? _lastSyncedAt;
        private BPAStatusMessage _message;
        private AccountLevelBpaSyncStatus _status;

        /// <summary>
        /// Gets and sets the property BpaImpactsLightsail. 
        /// <para>
        /// A Boolean value that indicates whether account-level block public access is affecting
        /// your Lightsail buckets.
        /// </para>
        /// </summary>
        public bool? BpaImpactsLightsail
        {
            get { return this._bpaImpactsLightsail; }
            set { this._bpaImpactsLightsail = value; }
        }

        // Check to see if BpaImpactsLightsail property is set
        internal bool IsSetBpaImpactsLightsail()
        {
            return this._bpaImpactsLightsail.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastSyncedAt. 
        /// <para>
        /// The timestamp of when the account-level BPA configuration was last synchronized. This
        /// value is null when the account-level BPA configuration has not been synchronized.
        /// </para>
        /// </summary>
        public DateTime? LastSyncedAt
        {
            get { return this._lastSyncedAt; }
            set { this._lastSyncedAt = value; }
        }

        // Check to see if LastSyncedAt property is set
        internal bool IsSetLastSyncedAt()
        {
            return this._lastSyncedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message that provides a reason for a <c>Failed</c> or <c>Defaulted</c> synchronization
        /// status.
        /// </para>
        ///  
        /// <para>
        /// The following messages are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SYNC_ON_HOLD</c> - The synchronization has not yet happened. This status message
        /// occurs immediately after you create your first Lightsail bucket. This status message
        /// should change after the first synchronization happens, approximately 1 hour after
        /// the first bucket is created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DEFAULTED_FOR_SLR_MISSING</c> - The synchronization failed because the required
        /// service-linked role is missing from your Amazon Web Services account. The account-level
        /// BPA configuration for your Lightsail buckets is defaulted to <i>active</i> until the
        /// synchronization can occur. This means that all your buckets are private and not publicly
        /// accessible. For more information about how to create the required service-linked role
        /// to allow synchronization, see <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-using-service-linked-roles">Using
        /// Service-Linked Roles for Amazon Lightsail</a> in the <i>Amazon Lightsail Developer
        /// Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DEFAULTED_FOR_SLR_MISSING_ON_HOLD</c> - The synchronization failed because the
        /// required service-linked role is missing from your Amazon Web Services account. Account-level
        /// BPA is not yet configured for your Lightsail buckets. Therefore, only the bucket access
        /// permissions and individual object access permissions apply to your Lightsail buckets.
        /// For more information about how to create the required service-linked role to allow
        /// synchronization, see <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-using-service-linked-roles">Using
        /// Service-Linked Roles for Amazon Lightsail</a> in the <i>Amazon Lightsail Developer
        /// Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Unknown</c> - The reason that synchronization failed is unknown. Contact Amazon
        /// Web Services Support for more information.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public BPAStatusMessage Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the account-level BPA synchronization.
        /// </para>
        ///  
        /// <para>
        /// The following statuses are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>InSync</c> - Account-level BPA is synchronized. The Amazon S3 account-level BPA
        /// configuration applies to your Lightsail buckets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NeverSynced</c> - Synchronization has not yet happened. The Amazon S3 account-level
        /// BPA configuration does not apply to your Lightsail buckets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failed</c> - Synchronization failed. The Amazon S3 account-level BPA configuration
        /// does not apply to your Lightsail buckets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Defaulted</c> - Synchronization failed and account-level BPA for your Lightsail
        /// buckets is defaulted to <i>active</i>.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// You might need to complete further actions if the status is <c>Failed</c> or <c>Defaulted</c>.
        /// The <c>message</c> parameter provides more information for those statuses.
        /// </para>
        ///  </note>
        /// </summary>
        public AccountLevelBpaSyncStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}