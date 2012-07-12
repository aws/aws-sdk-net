/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// <para> Available option. </para>
    /// </summary>
    public class OptionGroupOption  
    {
        
        private string name;
        private string description;
        private string engineName;
        private string majorEngineVersion;
        private string minimumRequiredMinorEngineVersion;
        private bool? portRequired;
        private int? defaultPort;
        private List<string> optionsDependedOn = new List<string>();

        /// <summary>
        /// The name of the option.
        ///  
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        public OptionGroupOption WithName(string name)
        {
            this.name = name;
            return this;
        }
            

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;       
        }

        /// <summary>
        /// The description of the option.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The value to set for the Description property </param>
        /// <returns>this instance</returns>
        public OptionGroupOption WithDescription(string description)
        {
            this.description = description;
            return this;
        }
            

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;       
        }

        /// <summary>
        /// Engine name that this option can be applied to.
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
        public OptionGroupOption WithEngineName(string engineName)
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
        /// Indicates the major engine version that the option is available for.
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
        public OptionGroupOption WithMajorEngineVersion(string majorEngineVersion)
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
        /// The minimum required engine version for the option to be applied.
        ///  
        /// </summary>
        public string MinimumRequiredMinorEngineVersion
        {
            get { return this.minimumRequiredMinorEngineVersion; }
            set { this.minimumRequiredMinorEngineVersion = value; }
        }

        /// <summary>
        /// Sets the MinimumRequiredMinorEngineVersion property
        /// </summary>
        /// <param name="minimumRequiredMinorEngineVersion">The value to set for the MinimumRequiredMinorEngineVersion property </param>
        /// <returns>this instance</returns>
        public OptionGroupOption WithMinimumRequiredMinorEngineVersion(string minimumRequiredMinorEngineVersion)
        {
            this.minimumRequiredMinorEngineVersion = minimumRequiredMinorEngineVersion;
            return this;
        }
            

        // Check to see if MinimumRequiredMinorEngineVersion property is set
        internal bool IsSetMinimumRequiredMinorEngineVersion()
        {
            return this.minimumRequiredMinorEngineVersion != null;       
        }

        /// <summary>
        /// Specifies whether the option requires a port.
        ///  
        /// </summary>
        public bool PortRequired
        {
            get { return this.portRequired ?? default(bool); }
            set { this.portRequired = value; }
        }

        /// <summary>
        /// Sets the PortRequired property
        /// </summary>
        /// <param name="portRequired">The value to set for the PortRequired property </param>
        /// <returns>this instance</returns>
        public OptionGroupOption WithPortRequired(bool portRequired)
        {
            this.portRequired = portRequired;
            return this;
        }
            

        // Check to see if PortRequired property is set
        internal bool IsSetPortRequired()
        {
            return this.portRequired.HasValue;       
        }

        /// <summary>
        /// If the option requires a port, specifies the default port for the option.
        ///  
        /// </summary>
        public int DefaultPort
        {
            get { return this.defaultPort ?? default(int); }
            set { this.defaultPort = value; }
        }

        /// <summary>
        /// Sets the DefaultPort property
        /// </summary>
        /// <param name="defaultPort">The value to set for the DefaultPort property </param>
        /// <returns>this instance</returns>
        public OptionGroupOption WithDefaultPort(int defaultPort)
        {
            this.defaultPort = defaultPort;
            return this;
        }
            

        // Check to see if DefaultPort property is set
        internal bool IsSetDefaultPort()
        {
            return this.defaultPort.HasValue;       
        }

        /// <summary>
        /// List of all options that are prerequisites for this option.
        ///  
        /// </summary>
        public List<string> OptionsDependedOn
        {
            get { return this.optionsDependedOn; }
            set { this.optionsDependedOn = value; }
        }
        /// <summary>
        /// Adds elements to the OptionsDependedOn collection
        /// </summary>
        /// <param name="optionsDependedOn">The values to add to the OptionsDependedOn collection </param>
        /// <returns>this instance</returns>
        public OptionGroupOption WithOptionsDependedOn(params string[] optionsDependedOn)
        {
            foreach (string element in optionsDependedOn)
            {
                this.optionsDependedOn.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the OptionsDependedOn collection
        /// </summary>
        /// <param name="optionsDependedOn">The values to add to the OptionsDependedOn collection </param>
        /// <returns>this instance</returns>
        public OptionGroupOption WithOptionsDependedOn(IEnumerable<string> optionsDependedOn)
        {
            foreach (string element in optionsDependedOn)
            {
                this.optionsDependedOn.Add(element);
            }

            return this;
        }

        // Check to see if OptionsDependedOn property is set
        internal bool IsSetOptionsDependedOn()
        {
            return this.optionsDependedOn.Count > 0;       
        }
    }
}
