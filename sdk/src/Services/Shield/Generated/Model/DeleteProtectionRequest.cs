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
    /// Container for the parameters to the DeleteProtection operation.
    /// Deletes an Shield Advanced <a>Protection</a>.
    /// </summary>
    public partial class DeleteProtectionRequest : AmazonShieldRequest
    {
        private string _protectionId;

        /// <summary>
        /// Gets and sets the property ProtectionId. 
        /// <para>
        /// The unique identifier (ID) for the <a>Protection</a> object to be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
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

    }
}