/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// <para> The returned result of the corresponding request. </para>
    /// </summary>
    public class ListDistributionsResult  
    {
        
        private DistributionList distributionList;

        /// <summary>
        /// The DistributionList type.
        ///  
        /// </summary>
        public DistributionList DistributionList
        {
            get { return this.distributionList; }
            set { this.distributionList = value; }
        }

        /// <summary>
        /// Sets the DistributionList property
        /// </summary>
        /// <param name="distributionList">The value to set for the DistributionList property </param>
        /// <returns>this instance</returns>
        public ListDistributionsResult WithDistributionList(DistributionList distributionList)
        {
            this.distributionList = distributionList;
            return this;
        }
            

        // Check to see if DistributionList property is set
        internal bool IsSetDistributionList()
        {
            return this.distributionList != null;       
        }
    }
}
