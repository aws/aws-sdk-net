/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Container for the parameters to the PutAccessPointPolicy operation.
    /// Associates an access policy with the specified access point. Each access point can
    /// have only one policy, so a request made to this API replaces any existing policy associated
    /// with the specified access point.
    /// </summary>
    public partial class PutAccessPointPolicyRequest : AmazonS3ControlRequest
    {
        private string _accountId;
        private string _name;
        private string _policy;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The AWS account ID for owner of the bucket associated with the specified access point.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the access point that you want to associate with the specified policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=50)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The policy that you want to apply to the specified access point. For more information
        /// about access point policies, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/access-points.html">Managing
        /// Data Access with Amazon S3 Access Points</a> in the <i>Amazon Simple Storage Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

    }
}