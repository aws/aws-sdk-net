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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// <para>A complex type that contains the information for each change in a change batch request.</para>
    /// </summary>
    public class Change
    {
        
        private ChangeAction action;
        private ResourceRecordSet resourceRecordSet;

        /// <summary>
        /// The action to perform. Valid values: <c>CREATE</c> | <c>DELETE</c>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>CREATE, DELETE</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ChangeAction Action
        {
            get { return this.action; }
            set { this.action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this.action != null;
        }

        /// <summary>
        /// Information about the resource record set to create or delete.
        ///  
        /// </summary>
        public ResourceRecordSet ResourceRecordSet
        {
            get { return this.resourceRecordSet; }
            set { this.resourceRecordSet = value; }
        }

        // Check to see if ResourceRecordSet property is set
        internal bool IsSetResourceRecordSet()
        {
            return this.resourceRecordSet != null;
        }
    }
}
