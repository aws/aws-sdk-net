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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteAccountSubscription operation.
    /// <important> 
    /// <para>
    /// Deleting your QuickSight account subscription has permanent, irreversible consequences
    /// across all Amazon Web Services regions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Global deletion – Running this operation from any single region will delete your QuickSight
    /// account and all data in every Amazon Web Services region where you have QuickSight
    /// resources.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Complete data loss – All dashboards, analyses, datasets, data sources, and custom
    /// visuals will be permanently deleted across all regions.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Embedded content failure – All embedded dashboards and visuals in your applications
    /// will immediately stop working and display errors to end users.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Shared resources removed – All shared dashboards, folders, and resources will become
    /// inaccessible to other users and external recipients.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// User access terminated – All QuickSight users in your account will lose access immediately,
    /// including authors, readers, and administrators.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>No recovery possible</b> – Once deleted, your QuickSight account and all associated
    /// data cannot be restored.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Consider exporting critical dashboards and data before proceeding with account deletion.
    /// </para>
    ///  </important> 
    /// <para>
    /// Use the <c>DeleteAccountSubscription</c> operation to delete an QuickSight account.
    /// This operation will result in an error message if you have configured your account
    /// termination protection settings to <c>True</c>. To change this setting and delete
    /// your account, call the <c>UpdateAccountSettings</c> API and set the value of the <c>TerminationProtectionEnabled</c>
    /// parameter to <c>False</c>, then make another call to the <c>DeleteAccountSubscription</c>
    /// API.
    /// </para>
    /// </summary>
    public partial class DeleteAccountSubscriptionRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the account that you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

    }
}