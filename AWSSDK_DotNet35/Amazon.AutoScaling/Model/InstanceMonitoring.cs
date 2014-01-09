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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// <para> The <c>InstanceMonitoring</c> data type. </para>
    /// </summary>
    public class InstanceMonitoring
    {
        
        private bool? enabled;


        /// <summary>
        /// If <c>True</c>, instance monitoring is enabled.
        ///  
        /// </summary>
        public bool Enabled
        {
            get { return this.enabled ?? default(bool); }
            set { this.enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this.enabled.HasValue;
        }
    }
}
