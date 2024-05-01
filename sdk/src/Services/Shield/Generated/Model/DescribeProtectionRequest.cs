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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
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
namespace Amazon.Shield.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeProtection operation.
    /// Lists the details of a <a>Protection</a> object.
    /// </summary>
    public partial class DescribeProtectionRequest : AmazonShieldRequest
    {
        private string _protectionId;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property ProtectionId. 
        /// <para>
        /// The unique identifier (ID) for the <a>Protection</a> object to describe. You must
        /// provide either the <c>ResourceArn</c> of the protected resource or the <c>ProtectionID</c>
        /// of the protection, but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string ProtectionId
        {
            get { return this._protectionId; }
            set { this._protectionId = value; }
        }

        // Check to see if ProtectionId property is set
        internal bool IsSetProtectionId()
        {
            return this._protectionId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN (Amazon Resource Name) of the protected Amazon Web Services resource. You
        /// must provide either the <c>ResourceArn</c> of the protected resource or the <c>ProtectionID</c>
        /// of the protection, but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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

    }
}