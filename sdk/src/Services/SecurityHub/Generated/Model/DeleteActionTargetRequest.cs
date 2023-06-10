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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteActionTarget operation.
    /// Deletes a custom action target from Security Hub.
    /// 
    ///  
    /// <para>
    /// Deleting a custom action target does not affect any findings or insights that were
    /// already sent to Amazon CloudWatch Events using the custom action.
    /// </para>
    /// </summary>
    public partial class DeleteActionTargetRequest : AmazonSecurityHubRequest
    {
        private string _actionTargetArn;

        /// <summary>
        /// Gets and sets the property ActionTargetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the custom action target to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ActionTargetArn
        {
            get { return this._actionTargetArn; }
            set { this._actionTargetArn = value; }
        }

        // Check to see if ActionTargetArn property is set
        internal bool IsSetActionTargetArn()
        {
            return this._actionTargetArn != null;
        }

    }
}