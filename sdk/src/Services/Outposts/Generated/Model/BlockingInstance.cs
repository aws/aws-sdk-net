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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
namespace Amazon.Outposts.Model
{
    /// <summary>
    /// A running Amazon EC2 instance that can be stopped to free up capacity needed to run
    /// the capacity task.
    /// </summary>
    public partial class BlockingInstance
    {
        private string _accountId;
        private AWSServiceName _awsServiceName;
        private string _instanceId;

        /// <summary>
        /// Gets and sets the property AccountId.
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
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
        /// Gets and sets the property AwsServiceName. 
        /// <para>
        /// The Amazon Web Services service name that owns the specified blocking instance.
        /// </para>
        /// </summary>
        public AWSServiceName AwsServiceName
        {
            get { return this._awsServiceName; }
            set { this._awsServiceName = value; }
        }

        // Check to see if AwsServiceName property is set
        internal bool IsSetAwsServiceName()
        {
            return this._awsServiceName != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the blocking instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=11, Max=32)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

    }
}