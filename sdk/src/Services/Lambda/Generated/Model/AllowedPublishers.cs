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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// List of signing profiles that can sign a code package.
    /// </summary>
    public partial class AllowedPublishers
    {
        private List<string> _signingProfileVersionArns = new List<string>();

        /// <summary>
        /// Gets and sets the property SigningProfileVersionArns. 
        /// <para>
        /// The Amazon Resource Name (ARN) for each of the signing profiles. A signing profile
        /// defines a trusted user who can sign a code package. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<string> SigningProfileVersionArns
        {
            get { return this._signingProfileVersionArns; }
            set { this._signingProfileVersionArns = value; }
        }

        // Check to see if SigningProfileVersionArns property is set
        internal bool IsSetSigningProfileVersionArns()
        {
            return this._signingProfileVersionArns != null && this._signingProfileVersionArns.Count > 0; 
        }

    }
}