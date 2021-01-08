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
    /// This is the response object from the DescribeProtection operation.
    /// </summary>
    public partial class DescribeProtectionResponse : AmazonWebServiceResponse
    {
        private Protection _protection;

        /// <summary>
        /// Gets and sets the property Protection. 
        /// <para>
        /// The <a>Protection</a> object that is described.
        /// </para>
        /// </summary>
        public Protection Protection
        {
            get { return this._protection; }
            set { this._protection = value; }
        }

        // Check to see if Protection property is set
        internal bool IsSetProtection()
        {
            return this._protection != null;
        }

    }
}