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
    /// <para>Describes a Reserved Instance listing state.</para>
    /// </summary>
    public class InstanceCount
    {
        
        private ListingState state;
        private int? count;


        /// <summary>
        /// The states of the listed Reserved Instances.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>available, sold, cancelled, pending</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ListingState State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this.state != null;
        }

        /// <summary>
        /// he number of listed Reserved Instances in the state specified by the <c>state</c>.
        ///  
        /// </summary>
        public int Count
        {
            get { return this.count ?? default(int); }
            set { this.count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this.count.HasValue;
        }
    }
}
