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
    /// This is the response object from the PutResourcePolicy operation.
    /// </summary>
    public partial class PutResourcePolicyResponse : AmazonWebServiceResponse
    {
        private string _resourceArn;
        private string _resourcePolicy;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the CloudTrail channel attached to the resource-based
        /// policy. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=256)]
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
        ///  The JSON-formatted string of the Amazon Web Services resource-based policy attached
        /// to the CloudTrail channel. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8192)]
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