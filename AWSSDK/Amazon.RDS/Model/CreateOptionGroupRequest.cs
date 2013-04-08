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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the CreateOptionGroup operation.
    /// <para> Creates a new Option Group. You can create up to 20 option groups. </para>
    /// </summary>
    /// <seealso cref="Amazon.RDS.AmazonRDS.CreateOptionGroup"/>
    public class CreateOptionGroupRequest : AmazonWebServiceRequest
    {
        private string optionGroupName;
        private string engineName;
        private string majorEngineVersion;
        private string optionGroupDescription;

        /// <summary>
        /// Specifies the name of the option group to be created. Constraints: <ul> <li>Must be 1 to 255 alphanumeric characters or hyphens</li>
        /// <li>First character must be a letter</li> <li>Cannot end with a hyphen or contain two consecutive hyphens</li> </ul> Example:
        /// <c>myOptiongroup</c>
        ///  
        /// </summary>
        public string OptionGroupName
        {
            get { return this.optionGroupName; }
            set { this.optionGroupName = value; }
        }

        /// <summary>
        /// Sets the OptionGroupName property
        /// </summary>
        /// <param name="optionGroupName">The value to set for the OptionGroupName property </param>
        /// <returns>this instance</returns>
        public CreateOptionGroupRequest WithOptionGroupName(string optionGroupName)
        {
            this.optionGroupName = optionGroupName;
            return this;
        }
            

        // Check to see if OptionGroupName property is set
        internal bool IsSetOptionGroupName()
        {
            return this.optionGroupName != null;
        }

        /// <summary>
        /// Specifies the name of the engine that this option group should be associated with.
        ///  
        /// </summary>
        public string EngineName
        {
            get { return this.engineName; }
            set { this.engineName = value; }
        }

        /// <summary>
        /// Sets the EngineName property
        /// </summary>
        /// <param name="engineName">The value to set for the EngineName property </param>
        /// <returns>this instance</returns>
        public CreateOptionGroupRequest WithEngineName(string engineName)
        {
            this.engineName = engineName;
            return this;
        }
            

        // Check to see if EngineName property is set
        internal bool IsSetEngineName()
        {
            return this.engineName != null;
        }

        /// <summary>
        /// Specifies the major version of the engine that this option group should be associated with.
        ///  
        /// </summary>
        public string MajorEngineVersion
        {
            get { return this.majorEngineVersion; }
            set { this.majorEngineVersion = value; }
        }

        /// <summary>
        /// Sets the MajorEngineVersion property
        /// </summary>
        /// <param name="majorEngineVersion">The value to set for the MajorEngineVersion property </param>
        /// <returns>this instance</returns>
        public CreateOptionGroupRequest WithMajorEngineVersion(string majorEngineVersion)
        {
            this.majorEngineVersion = majorEngineVersion;
            return this;
        }
            

        // Check to see if MajorEngineVersion property is set
        internal bool IsSetMajorEngineVersion()
        {
            return this.majorEngineVersion != null;
        }

        /// <summary>
        /// The description of the option group.
        ///  
        /// </summary>
        public string OptionGroupDescription
        {
            get { return this.optionGroupDescription; }
            set { this.optionGroupDescription = value; }
        }

        /// <summary>
        /// Sets the OptionGroupDescription property
        /// </summary>
        /// <param name="optionGroupDescription">The value to set for the OptionGroupDescription property </param>
        /// <returns>this instance</returns>
        public CreateOptionGroupRequest WithOptionGroupDescription(string optionGroupDescription)
        {
            this.optionGroupDescription = optionGroupDescription;
            return this;
        }
            

        // Check to see if OptionGroupDescription property is set
        internal bool IsSetOptionGroupDescription()
        {
            return this.optionGroupDescription != null;
        }
    }
}
    
