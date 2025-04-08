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
    /// An Amazon EC2 instance.
    /// </summary>
    public partial class AssetInstance
    {
        private string _accountId;
        private string _assetId;
        private AWSServiceName _awsServiceName;
        private string _instanceId;
        private string _instanceType;

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
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The ID of the asset. An Outpost asset can be a single server within an Outposts rack
        /// or an Outposts server configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string AssetId
        {
            get { return this._assetId; }
            set { this._assetId = value; }
        }

        // Check to see if AssetId property is set
        internal bool IsSetAssetId()
        {
            return this._assetId != null;
        }

        /// <summary>
        /// Gets and sets the property AwsServiceName. 
        /// <para>
        /// The Amazon Web Services service name of the instance.
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
        /// The ID of the instance.
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

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The type of instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=30)]
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

    }
}