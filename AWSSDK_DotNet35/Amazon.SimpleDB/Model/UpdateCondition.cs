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

namespace Amazon.SimpleDB.Model
{
    /// <summary>
    /// <para> Specifies the conditions under which data should be updated. If an update condition is specified for a request, the data will only be
    /// updated if the condition is satisfied. For example, if an attribute with a specific name and value exists, or if a specific attribute
    /// doesn't exist. </para>
    /// </summary>
    public class UpdateCondition
    {
        
        private string name;
        private string value;
        private bool? exists;

        /// <summary>
        /// The name of the attribute involved in the condition.
        ///  
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// The value of an attribute. This value can only be specified when the <c>Exists</c> parameter is equal to <c>true</c>.
        ///  
        /// </summary>
        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this.value != null;
        }

        /// <summary>
        /// A value specifying whether or not the specified attribute must exist with the specified value in order for the update condition to be
        /// satisfied. Specify <c>true</c> if the attribute must exist for the update condition to be satisfied. Specify <c>false</c> if the attribute
        /// should not exist in order for the update condition to be satisfied.
        ///  
        /// </summary>
        public bool Exists
        {
            get { return this.exists ?? default(bool); }
            set { this.exists = value; }
        }

        // Check to see if Exists property is set
        internal bool IsSetExists()
        {
            return this.exists.HasValue;
        }
    }
}
