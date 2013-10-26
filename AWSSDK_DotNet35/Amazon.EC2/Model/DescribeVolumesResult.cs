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
    /// <para> The result of describing your EBS volumes. </para>
    /// </summary>
    public partial class DescribeVolumesResult : AmazonWebServiceResponse
    {
        
        private List<Volume> volumes = new List<Volume>();


        /// <summary>
        /// The list of described EBS volumes.
        ///  
        /// </summary>
        public List<Volume> Volumes
        {
            get { return this.volumes; }
            set { this.volumes = value; }
        }

        // Check to see if Volumes property is set
        internal bool IsSetVolumes()
        {
            return this.volumes.Count > 0;
        }
    }
}
