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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the DescribeKeyPairs operation.
    /// </summary>
    public partial class DescribeKeyPairsResponse : AmazonWebServiceResponse
    {
        private List<KeyPairInfo> _keyPairs = new List<KeyPairInfo>();

        /// <summary>
        /// Gets and sets the property KeyPairs. 
        /// <para>
        /// Information about the key pairs.
        /// </para>
        /// </summary>
        public List<KeyPairInfo> KeyPairs
        {
            get { return this._keyPairs; }
            set { this._keyPairs = value; }
        }

        // Check to see if KeyPairs property is set
        internal bool IsSetKeyPairs()
        {
            return this._keyPairs != null && this._keyPairs.Count > 0; 
        }

    }
}