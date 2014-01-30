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
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeKeyPairs operation.
    /// <para>Describes one or more of your key pairs.</para> <para>For more information about key pairs, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html" >Key Pairs</a> in the <i>Amazon Elastic Compute Cloud User
    /// Guide</i> .</para>
    /// </summary>
    public partial class DescribeKeyPairsRequest : AmazonEC2Request
    {
        private List<string> keyNames = new List<string>();
        private List<Filter> filters = new List<Filter>();


        /// <summary>
        /// One or more key pair names. Default: Describes all your key pairs.
        ///  
        /// </summary>
        public List<string> KeyNames
        {
            get { return this.keyNames; }
            set { this.keyNames = value; }
        }

        // Check to see if KeyNames property is set
        internal bool IsSetKeyNames()
        {
            return this.keyNames.Count > 0;
        }

        /// <summary>
        /// One or more filters. <ul> <li> <c>fingerprint</c> - The fingerprint of the key pair. </li> <li> <c>key-name</c> - The name of the key pair.
        /// </li> </ul>
        ///  
        /// </summary>
        public List<Filter> Filters
        {
            get { return this.filters; }
            set { this.filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this.filters.Count > 0;
        }

    }
}
    
