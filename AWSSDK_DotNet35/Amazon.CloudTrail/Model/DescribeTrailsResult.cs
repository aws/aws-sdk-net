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

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// <para>Returns the objects or data listed below if successful. Otherwise, returns an error.</para>
    /// </summary>
    public partial class DescribeTrailsResult : AmazonWebServiceResponse
    {
        
        private List<Trail> trailList = new List<Trail>();


        /// <summary>
        /// An array of <a>Trail</a> objects.
        ///  
        /// </summary>
        public List<Trail> TrailList
        {
            get { return this.trailList; }
            set { this.trailList = value; }
        }

        // Check to see if TrailList property is set
        internal bool IsSetTrailList()
        {
            return this.trailList.Count > 0;
        }
    }
}
