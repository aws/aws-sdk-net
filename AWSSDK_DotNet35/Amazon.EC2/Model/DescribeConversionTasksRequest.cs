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
    /// Container for the parameters to the DescribeConversionTasks operation.
    /// <para>Describes one or more of your conversion tasks. For more information, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UploadingYourInstancesandVolumes.html" >Using the Command Line Tools to Import Your
    /// Virtual Machine to Amazon EC2</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
    /// </summary>
    public partial class DescribeConversionTasksRequest : AmazonEC2Request
    {
        private List<Filter> filters = new List<Filter>();
        private List<string> conversionTaskIds = new List<string>();


        /// <summary>
        /// 
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

        /// <summary>
        /// One or more conversion task IDs.
        ///  
        /// </summary>
        public List<string> ConversionTaskIds
        {
            get { return this.conversionTaskIds; }
            set { this.conversionTaskIds = value; }
        }

        // Check to see if ConversionTaskIds property is set
        internal bool IsSetConversionTaskIds()
        {
            return this.conversionTaskIds.Count > 0;
        }

    }
}
    
