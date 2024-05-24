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
    /// Container for the parameters to the DeleteProtectionGroup operation.
    /// Removes the specified protection group.
    /// </summary>
    public partial class DeleteProtectionGroupRequest : AmazonShieldRequest
    {
        private string _protectionGroupId;

        /// <summary>
        /// Gets and sets the property ProtectionGroupId. 
        /// <para>
        /// The name of the protection group. You use this to identify the protection group in
        /// lists and to manage the protection group, for example to update, delete, or describe
        /// it. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
        public string ProtectionGroupId
        {
            get { return this._protectionGroupId; }
            set { this._protectionGroupId = value; }
        }

        // Check to see if ProtectionGroupId property is set
        internal bool IsSetProtectionGroupId()
        {
            return this._protectionGroupId != null;
        }

    }
}