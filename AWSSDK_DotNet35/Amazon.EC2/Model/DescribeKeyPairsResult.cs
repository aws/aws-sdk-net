/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para> The result of describing a user's key pairs. </para>
    /// </summary>
    public partial class DescribeKeyPairsResult : AmazonWebServiceResponse
    {
        
        private List<KeyPairInfo> keyPairs = new List<KeyPairInfo>();


        /// <summary>
        /// The list of described key pairs.
        ///  
        /// </summary>
        public List<KeyPairInfo> KeyPairs
        {
            get { return this.keyPairs; }
            set { this.keyPairs = value; }
        }

        // Check to see if KeyPairs property is set
        internal bool IsSetKeyPairs()
        {
            return this.keyPairs.Count > 0;
        }
    }
}
