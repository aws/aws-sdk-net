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
    /// <para> An Auto Scaling process that has been suspended. For more information, see ProcessType. </para>
    /// </summary>
    public class SuspendedProcess  
    {
        
        private string processName;
        private string suspensionReason;

        /// <summary>
        /// The name of the suspended process.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ProcessName
        {
            get { return this.processName; }
            set { this.processName = value; }
        }

        /// <summary>
        /// Sets the ProcessName property
        /// </summary>
        /// <param name="processName">The value to set for the ProcessName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SuspendedProcess WithProcessName(string processName)
        {
            this.processName = processName;
            return this;
        }
            

        // Check to see if ProcessName property is set
        internal bool IsSetProcessName()
        {
            return this.processName != null;       
        }

        /// <summary>
        /// The reason that the process was suspended.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string SuspensionReason
        {
            get { return this.suspensionReason; }
            set { this.suspensionReason = value; }
        }

        /// <summary>
        /// Sets the SuspensionReason property
        /// </summary>
        /// <param name="suspensionReason">The value to set for the SuspensionReason property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SuspendedProcess WithSuspensionReason(string suspensionReason)
        {
            this.suspensionReason = suspensionReason;
            return this;
        }
            

        // Check to see if SuspensionReason property is set
        internal bool IsSetSuspensionReason()
        {
            return this.suspensionReason != null;       
        }
    }
}
