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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// <para>The TemplateParameter data type.</para>
    /// </summary>
    public class TemplateParameter
    {
        
        private string parameterKey;
        private string defaultValue;
        private bool? noEcho;
        private string description;


        /// <summary>
        /// The name associated with the parameter.
        ///  
        /// </summary>
        public string ParameterKey
        {
            get { return this.parameterKey; }
            set { this.parameterKey = value; }
        }

        // Check to see if ParameterKey property is set
        internal bool IsSetParameterKey()
        {
            return this.parameterKey != null;
        }

        /// <summary>
        /// The default value associated with the parameter.
        ///  
        /// </summary>
        public string DefaultValue
        {
            get { return this.defaultValue; }
            set { this.defaultValue = value; }
        }

        // Check to see if DefaultValue property is set
        internal bool IsSetDefaultValue()
        {
            return this.defaultValue != null;
        }

        /// <summary>
        /// Flag indicating whether the parameter should be displayed as plain text in logs and UIs.
        ///  
        /// </summary>
        public bool NoEcho
        {
            get { return this.noEcho ?? default(bool); }
            set { this.noEcho = value; }
        }

        // Check to see if NoEcho property is set
        internal bool IsSetNoEcho()
        {
            return this.noEcho.HasValue;
        }

        /// <summary>
        /// User defined description associated with the parameter.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }
    }
}
