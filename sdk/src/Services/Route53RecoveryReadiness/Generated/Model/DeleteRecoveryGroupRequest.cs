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
 * Do not modify this file. This file is generated from the route53-recovery-readiness-2019-12-02.normal.json service model.
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
namespace Amazon.Route53RecoveryReadiness.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteRecoveryGroup operation.
    /// Deletes a recovery group.
    /// </summary>
    public partial class DeleteRecoveryGroupRequest : AmazonRoute53RecoveryReadinessRequest
    {
        private string _recoveryGroupName;

        /// <summary>
        /// Gets and sets the property RecoveryGroupName. 
        /// <para>
        /// The name of a recovery group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RecoveryGroupName
        {
            get { return this._recoveryGroupName; }
            set { this._recoveryGroupName = value; }
        }

        // Check to see if RecoveryGroupName property is set
        internal bool IsSetRecoveryGroupName()
        {
            return this._recoveryGroupName != null;
        }

    }
}