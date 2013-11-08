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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// <para>The information retrieved from the Amazon EC2 instances.</para>
    /// </summary>
    public class EnvironmentInfoDescription
    {
        
        private EnvironmentInfoType infoType;
        private string ec2InstanceId;
        private DateTime? sampleTimestamp;
        private string message;

        /// <summary>
        /// The type of information retrieved.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>tail</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public EnvironmentInfoType InfoType
        {
            get { return this.infoType; }
            set { this.infoType = value; }
        }

        // Check to see if InfoType property is set
        internal bool IsSetInfoType()
        {
            return this.infoType != null;
        }

        /// <summary>
        /// The Amazon EC2 Instance ID for this information.
        ///  
        /// </summary>
        public string Ec2InstanceId
        {
            get { return this.ec2InstanceId; }
            set { this.ec2InstanceId = value; }
        }

        // Check to see if Ec2InstanceId property is set
        internal bool IsSetEc2InstanceId()
        {
            return this.ec2InstanceId != null;
        }

        /// <summary>
        /// The time stamp when this information was retrieved.
        ///  
        /// </summary>
        public DateTime SampleTimestamp
        {
            get { return this.sampleTimestamp ?? default(DateTime); }
            set { this.sampleTimestamp = value; }
        }

        // Check to see if SampleTimestamp property is set
        internal bool IsSetSampleTimestamp()
        {
            return this.sampleTimestamp.HasValue;
        }

        /// <summary>
        /// The retrieved information.
        ///  
        /// </summary>
        public string Message
        {
            get { return this.message; }
            set { this.message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this.message != null;
        }
    }
}
