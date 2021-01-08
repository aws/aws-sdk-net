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

namespace Amazon.Shield.Model
{
    /// <summary>
    /// This is the response object from the DescribeProtectionGroup operation.
    /// </summary>
    public partial class DescribeProtectionGroupResponse : AmazonWebServiceResponse
    {
        private ProtectionGroup _protectionGroup;

        /// <summary>
        /// Gets and sets the property ProtectionGroup. 
        /// <para>
        /// A grouping of protected resources that you and AWS Shield Advanced can monitor as
        /// a collective. This resource grouping improves the accuracy of detection and reduces
        /// false positives. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProtectionGroup ProtectionGroup
        {
            get { return this._protectionGroup; }
            set { this._protectionGroup = value; }
        }

        // Check to see if ProtectionGroup property is set
        internal bool IsSetProtectionGroup()
        {
            return this._protectionGroup != null;
        }

    }
}