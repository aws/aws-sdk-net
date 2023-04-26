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
    /// The alias of an Object Lambda Access Point. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/olap-use.html#ol-access-points-alias">How
    /// to use a bucket-style alias for your S3 bucket Object Lambda Access Point</a>.
    /// </summary>
    public partial class ObjectLambdaAccessPointAlias
    {
        private ObjectLambdaAccessPointAliasStatus _status;
        private string _value;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Object Lambda Access Point alias. If the status is <code>PROVISIONING</code>,
        /// the Object Lambda Access Point is provisioning the alias and the alias is not ready
        /// for use yet. If the status is <code>READY</code>, the Object Lambda Access Point alias
        /// is successfully provisioned and ready for use.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=16)]
        public ObjectLambdaAccessPointAliasStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The alias value of the Object Lambda Access Point.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=63)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}