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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// <para>A complex type containing the response for the request.</para>
    /// </summary>
    public partial class ChangeResourceRecordSetsResult : AmazonWebServiceResponse
    {
        
        private ChangeInfo changeInfo;

        /// <summary>
        /// A complex type that contains information about changes made to your hosted zone. This element contains an ID that you use when performing a
        /// <a>GetChange</a> action to get detailed information about the change.
        ///  
        /// </summary>
        public ChangeInfo ChangeInfo
        {
            get { return this.changeInfo; }
            set { this.changeInfo = value; }
        }

        // Check to see if ChangeInfo property is set
        internal bool IsSetChangeInfo()
        {
            return this.changeInfo != null;
        }
    }
}
