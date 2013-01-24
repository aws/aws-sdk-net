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

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeOfferingDetail operation.
    /// <para>Displays additional ordering step details for a specified Offering.</para>
    /// </summary>
    /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DescribeOfferingDetail"/>
    public class DescribeOfferingDetailRequest : AmazonWebServiceRequest
    {
        private string offeringId;

        /// <summary>
        /// The ID of the offering. Example: us-west-1_EqSV5_1G Default: None
        ///  
        /// </summary>
        public string OfferingId
        {
            get { return this.offeringId; }
            set { this.offeringId = value; }
        }

        /// <summary>
        /// Sets the OfferingId property
        /// </summary>
        /// <param name="offeringId">The value to set for the OfferingId property </param>
        /// <returns>this instance</returns>
        public DescribeOfferingDetailRequest WithOfferingId(string offeringId)
        {
            this.offeringId = offeringId;
            return this;
        }
            

        // Check to see if OfferingId property is set
        internal bool IsSetOfferingId()
        {
            return this.offeringId != null;       
        }
    }
}
    
