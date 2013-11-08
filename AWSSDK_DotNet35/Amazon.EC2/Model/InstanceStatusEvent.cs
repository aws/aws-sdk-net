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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para> Represents an event that affects the status of an Amazon EC2 instance. </para>
    /// </summary>
    public class InstanceStatusEvent
    {
        
        private EventCode code;
        private string description;
        private DateTime? notBefore;
        private DateTime? notAfter;


        /// <summary>
        /// The associated code of the event. Valid values: instance-reboot, system-reboot, instance-retirement
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>instance-reboot, system-reboot, system-maintenance, instance-retirement, instance-stop</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public EventCode Code
        {
            get { return this.code; }
            set { this.code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this.code != null;
        }

        /// <summary>
        /// A description of the event.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

        /// <summary>
        /// The earliest scheduled start time for the event.
        ///  
        /// </summary>
        public DateTime NotBefore
        {
            get { return this.notBefore ?? default(DateTime); }
            set { this.notBefore = value; }
        }

        // Check to see if NotBefore property is set
        internal bool IsSetNotBefore()
        {
            return this.notBefore.HasValue;
        }

        /// <summary>
        /// The latest scheduled end time for the event.
        ///  
        /// </summary>
        public DateTime NotAfter
        {
            get { return this.notAfter ?? default(DateTime); }
            set { this.notAfter = value; }
        }

        // Check to see if NotAfter property is set
        internal bool IsSetNotAfter()
        {
            return this.notAfter.HasValue;
        }
    }
}
