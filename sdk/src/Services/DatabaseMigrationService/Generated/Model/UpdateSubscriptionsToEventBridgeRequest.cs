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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSubscriptionsToEventBridge operation.
    /// Migrates 10 active and enabled Amazon SNS subscriptions at a time and converts them
    /// to corresponding Amazon EventBridge rules. By default, this operation migrates subscriptions
    /// only when all your replication instance versions are 3.4.5 or higher. If any replication
    /// instances are from versions earlier than 3.4.5, the operation raises an error and
    /// tells you to upgrade these instances to version 3.4.5 or higher. To enable migration
    /// regardless of version, set the <c>Force</c> option to true. However, if you don't
    /// upgrade instances earlier than version 3.4.5, some types of events might not be available
    /// when you use Amazon EventBridge.
    /// 
    ///  
    /// <para>
    /// To call this operation, make sure that you have certain permissions added to your
    /// user account. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Events.html#CHAP_Events-migrate-to-eventbridge">Migrating
    /// event subscriptions to Amazon EventBridge</a> in the <i>Amazon Web Services Database
    /// Migration Service User Guide</i>.
    /// </para>
    /// </summary>
    public partial class UpdateSubscriptionsToEventBridgeRequest : AmazonDatabaseMigrationServiceRequest
    {
        private bool? _forceMove;

        /// <summary>
        /// Gets and sets the property ForceMove. 
        /// <para>
        /// When set to true, this operation migrates DMS subscriptions for Amazon SNS notifications
        /// no matter what your replication instance version is. If not set or set to false, this
        /// operation runs only when all your replication instances are from DMS version 3.4.5
        /// or higher. 
        /// </para>
        /// </summary>
        public bool? ForceMove
        {
            get { return this._forceMove; }
            set { this._forceMove = value; }
        }

        // Check to see if ForceMove property is set
        internal bool IsSetForceMove()
        {
            return this._forceMove.HasValue; 
        }

    }
}