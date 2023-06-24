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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the UpdatePublicSharingSettings operation.
    /// Use the <code>UpdatePublicSharingSettings</code> operation to turn on or turn off
    /// the public sharing settings of an Amazon QuickSight dashboard.
    /// 
    ///  
    /// <para>
    /// To use this operation, turn on session capacity pricing for your Amazon QuickSight
    /// account.
    /// </para>
    ///  
    /// <para>
    /// Before you can turn on public sharing on your account, make sure to give public sharing
    /// permissions to an administrative user in the Identity and Access Management (IAM)
    /// console. For more information on using IAM with Amazon QuickSight, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/security_iam_service-with-iam.html">Using
    /// Amazon QuickSight with IAM</a> in the <i>Amazon QuickSight User Guide</i>.
    /// </para>
    /// </summary>
    public partial class UpdatePublicSharingSettingsRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private bool? _publicSharingEnabled;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID associated with your Amazon QuickSight subscription.
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

        /// <summary>
        /// Gets and sets the property PublicSharingEnabled. 
        /// <para>
        /// A Boolean value that indicates whether public sharing is turned on for an Amazon QuickSight
        /// account.
        /// </para>
        /// </summary>
        public bool PublicSharingEnabled
        {
            get { return this._publicSharingEnabled.GetValueOrDefault(); }
            set { this._publicSharingEnabled = value; }
        }

        // Check to see if PublicSharingEnabled property is set
        internal bool IsSetPublicSharingEnabled()
        {
            return this._publicSharingEnabled.HasValue; 
        }

    }
}