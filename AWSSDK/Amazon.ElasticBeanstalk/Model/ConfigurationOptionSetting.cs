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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// <para> A specification identifying an individual configuration option along with its current value. </para>
    /// </summary>
    public class ConfigurationOptionSetting  
    {
        
        private string namespaceValue;
        private string optionName;
        private string value;

        /// <summary>
        /// A unique namespace identifying the option's associated AWS resource.
        ///  
        /// </summary>
        public string Namespace
        {
            get { return this.namespaceValue; }
            set { this.namespaceValue = value; }
        }

        /// <summary>
        /// Sets the Namespace property
        /// </summary>
        /// <param name="namespaceValue">The value to set for the Namespace property </param>
        /// <returns>this instance</returns>
        public ConfigurationOptionSetting WithNamespace(string namespaceValue)
        {
            this.namespaceValue = namespaceValue;
            return this;
        }
            

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this.namespaceValue != null;       
        }

        /// <summary>
        /// The name of the configuration option.
        ///  
        /// </summary>
        public string OptionName
        {
            get { return this.optionName; }
            set { this.optionName = value; }
        }

        /// <summary>
        /// Sets the OptionName property
        /// </summary>
        /// <param name="optionName">The value to set for the OptionName property </param>
        /// <returns>this instance</returns>
        public ConfigurationOptionSetting WithOptionName(string optionName)
        {
            this.optionName = optionName;
            return this;
        }
            

        // Check to see if OptionName property is set
        internal bool IsSetOptionName()
        {
            return this.optionName != null;       
        }

        /// <summary>
        /// The current value for the configuration option.
        ///  
        /// </summary>
        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        /// <summary>
        /// Sets the Value property
        /// </summary>
        /// <param name="value">The value to set for the Value property </param>
        /// <returns>this instance</returns>
        public ConfigurationOptionSetting WithValue(string value)
        {
            this.value = value;
            return this;
        }
            

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this.value != null;       
        }
    }
}
