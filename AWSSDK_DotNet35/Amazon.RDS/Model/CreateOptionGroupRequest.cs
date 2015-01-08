/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
    /// Creates a new option group. You can create up to 20 option groups.
    /// </summary>
    public partial class CreateOptionGroupRequest : AmazonRDSRequest
    {
        private string _engineName;
        private string _majorEngineVersion;
        private string _optionGroupDescription;
        private string _optionGroupName;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property EngineName. 
        /// <para>
        ///  Specifies the name of the engine that this option group should be associated with.
        /// 
        /// </para>
        /// </summary>
        public string EngineName
        {
            get { return this._engineName; }
            set { this._engineName = value; }
        }

        // Check to see if EngineName property is set
        internal bool IsSetEngineName()
        {
            return this._engineName != null;
        }

        /// <summary>
        /// Gets and sets the property MajorEngineVersion. 
        /// <para>
        ///  Specifies the major version of the engine that this option group should be associated
        /// with. 
        /// </para>
        /// </summary>
        public string MajorEngineVersion
        {
            get { return this._majorEngineVersion; }
            set { this._majorEngineVersion = value; }
        }

        // Check to see if MajorEngineVersion property is set
        internal bool IsSetMajorEngineVersion()
        {
            return this._majorEngineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property OptionGroupDescription. 
        /// <para>
        ///  The description of the option group. 
        /// </para>
        /// </summary>
        public string OptionGroupDescription
        {
            get { return this._optionGroupDescription; }
            set { this._optionGroupDescription = value; }
        }

        // Check to see if OptionGroupDescription property is set
        internal bool IsSetOptionGroupDescription()
        {
            return this._optionGroupDescription != null;
        }

        /// <summary>
        /// Gets and sets the property OptionGroupName. 
        /// <para>
        ///  Specifies the name of the option group to be created. 
        /// </para>
        ///  
        /// <para>
        ///  Constraints: 
        /// </para>
        ///  <ul> <li>Must be 1 to 255 alphanumeric characters or hyphens</li> <li>First character
        /// must be a letter</li> <li>Cannot end with a hyphen or contain two consecutive hyphens</li>
        /// </ul> 
        /// <para>
        /// Example: <code>myoptiongroup</code>
        /// </para>
        /// </summary>
        public string OptionGroupName
        {
            get { return this._optionGroupName; }
            set { this._optionGroupName = value; }
        }

        // Check to see if OptionGroupName property is set
        internal bool IsSetOptionGroupName()
        {
            return this._optionGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}