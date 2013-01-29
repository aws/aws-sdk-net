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

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// <para> Detailed information about an activity type. </para>
    /// </summary>
    public class ActivityTypeDetail
    {
        
        private ActivityTypeInfo typeInfo;
        private ActivityTypeConfiguration configuration;

        /// <summary>
        /// General information about the activity type. The status of activity type (returned in the ActivityTypeInfo structure) can be one of the
        /// following. <ul> <li> <b>REGISTERED</b>: The type is registered and available. Workers supporting this type should be running. </li> <li>
        /// <b>DEPRECATED</b>: The type was deprecated using <a>DeprecateActivityType</a>, but is still in use. You should keep workers supporting this
        /// type running. You cannot create new tasks of this type. </li> </ul>
        ///  
        /// </summary>
        public ActivityTypeInfo TypeInfo
        {
            get { return this.typeInfo; }
            set { this.typeInfo = value; }
        }

        /// <summary>
        /// Sets the TypeInfo property
        /// </summary>
        /// <param name="typeInfo">The value to set for the TypeInfo property </param>
        /// <returns>this instance</returns>
        public ActivityTypeDetail WithTypeInfo(ActivityTypeInfo typeInfo)
        {
            this.typeInfo = typeInfo;
            return this;
        }
            

        // Check to see if TypeInfo property is set
        internal bool IsSetTypeInfo()
        {
            return this.typeInfo != null;
        }

        /// <summary>
        /// The configuration settings registered with the activity type.
        ///  
        /// </summary>
        public ActivityTypeConfiguration Configuration
        {
            get { return this.configuration; }
            set { this.configuration = value; }
        }

        /// <summary>
        /// Sets the Configuration property
        /// </summary>
        /// <param name="configuration">The value to set for the Configuration property </param>
        /// <returns>this instance</returns>
        public ActivityTypeDetail WithConfiguration(ActivityTypeConfiguration configuration)
        {
            this.configuration = configuration;
            return this;
        }
            

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this.configuration != null;
        }
    }
}
