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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Container for the parameters to the PutResourcePolicy operation.
    /// Attaches a resource-based permission policy to a CloudTrail channel that is used
    /// for an integration with an event source outside of Amazon Web Services. For more information
    /// about resource-based policies, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/security_iam_resource-based-policy-examples.html">CloudTrail
    /// resource-based policy examples</a> in the <i>CloudTrail User Guide</i>.
    /// </summary>
    public partial class PutResourcePolicyRequest : AmazonCloudTrailRequest
    {
        private string _resourceArn;
        private string _resourcePolicy;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the CloudTrail channel attached to the resource-based
        /// policy. The following is the format of a resource ARN: <code>arn:aws:cloudtrail:us-east-2:123456789012:channel/MyChannel</code>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=256)]
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

        /// <summary>
        /// Gets and sets the property ResourcePolicy. 
        /// <para>
        ///  A JSON-formatted string for an Amazon Web Services resource-based policy. 
        /// </para>
        ///  
        /// <para>
        /// The following are requirements for the resource policy:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  Contains only one action: cloudtrail-data:PutAuditEvents 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Contains at least one statement. The policy can have a maximum of 20 statements.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Each statement contains at least one principal. A statement can have a maximum of
        /// 50 principals. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=8192)]
        public string ResourcePolicy
        {
            get { return this._resourcePolicy; }
            set { this._resourcePolicy = value; }
        }

        // Check to see if ResourcePolicy property is set
        internal bool IsSetResourcePolicy()
        {
            return this._resourcePolicy != null;
        }

    }
}