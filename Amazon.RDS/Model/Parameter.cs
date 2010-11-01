/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> </para>
    /// </summary>
    public class Parameter  
    {
        
        private string parameterName;
        private string parameterValue;
        private string description;
        private string source;
        private string applyType;
        private string dataType;
        private string allowedValues;
        private bool? isModifiable;
        private string minimumEngineVersion;
        private string applyMethod;

        /// <summary>
        /// Specifies the name of the parameter.
        ///  
        /// </summary>
        public string ParameterName
        {
            get { return this.parameterName; }
            set { this.parameterName = value; }
        }

        /// <summary>
        /// Sets the ParameterName property
        /// </summary>
        /// <param name="parameterName">The value to set for the ParameterName property </param>
        /// <returns>this instance</returns>
        public Parameter WithParameterName(string parameterName)
        {
            this.parameterName = parameterName;
            return this;
        }
            
        // Check to see if ParameterName property is set
        internal bool IsSetParameterName()
        {
            return this.parameterName != null;      
        }

        /// <summary>
        /// Specifies the value of the parameter.
        ///  
        /// </summary>
        public string ParameterValue
        {
            get { return this.parameterValue; }
            set { this.parameterValue = value; }
        }

        /// <summary>
        /// Sets the ParameterValue property
        /// </summary>
        /// <param name="parameterValue">The value to set for the ParameterValue property </param>
        /// <returns>this instance</returns>
        public Parameter WithParameterValue(string parameterValue)
        {
            this.parameterValue = parameterValue;
            return this;
        }
            
        // Check to see if ParameterValue property is set
        internal bool IsSetParameterValue()
        {
            return this.parameterValue != null;         
        }

        /// <summary>
        /// Provides a description of the parameter.
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
        public Parameter WithDescription(string description)
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
        /// Indicates the source of the parameter value.
        ///  
        /// </summary>
        public string Source
        {
            get { return this.source; }
            set { this.source = value; }
        }

        /// <summary>
        /// Sets the Source property
        /// </summary>
        /// <param name="source">The value to set for the Source property </param>
        /// <returns>this instance</returns>
        public Parameter WithSource(string source)
        {
            this.source = source;
            return this;
        }
            
        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this.source != null;         
        }

        /// <summary>
        /// Specifies the engine specific parameters type.
        ///  
        /// </summary>
        public string ApplyType
        {
            get { return this.applyType; }
            set { this.applyType = value; }
        }

        /// <summary>
        /// Sets the ApplyType property
        /// </summary>
        /// <param name="applyType">The value to set for the ApplyType property </param>
        /// <returns>this instance</returns>
        public Parameter WithApplyType(string applyType)
        {
            this.applyType = applyType;
            return this;
        }
            
        // Check to see if ApplyType property is set
        internal bool IsSetApplyType()
        {
            return this.applyType != null;      
        }

        /// <summary>
        /// Specifies the valid data type for the parameter.
        ///  
        /// </summary>
        public string DataType
        {
            get { return this.dataType; }
            set { this.dataType = value; }
        }

        /// <summary>
        /// Sets the DataType property
        /// </summary>
        /// <param name="dataType">The value to set for the DataType property </param>
        /// <returns>this instance</returns>
        public Parameter WithDataType(string dataType)
        {
            this.dataType = dataType;
            return this;
        }
            
        // Check to see if DataType property is set
        internal bool IsSetDataType()
        {
            return this.dataType != null;       
        }

        /// <summary>
        /// Specifies the valid range of values for the parameter.
        ///  
        /// </summary>
        public string AllowedValues
        {
            get { return this.allowedValues; }
            set { this.allowedValues = value; }
        }

        /// <summary>
        /// Sets the AllowedValues property
        /// </summary>
        /// <param name="allowedValues">The value to set for the AllowedValues property </param>
        /// <returns>this instance</returns>
        public Parameter WithAllowedValues(string allowedValues)
        {
            this.allowedValues = allowedValues;
            return this;
        }
            
        // Check to see if AllowedValues property is set
        internal bool IsSetAllowedValues()
        {
            return this.allowedValues != null;      
        }

        /// <summary>
        /// Indicates whether (<i>true</i>) or not (<i>false</i>) the parameter
        /// can be modified. Some parameters have security or operational
        /// implications that prevent them from being changed.
        ///  
        /// </summary>
        public bool IsModifiable
        {
            get { return this.isModifiable ?? default(bool); }
            set { this.isModifiable = value; }
        }

        /// <summary>
        /// Sets the IsModifiable property
        /// </summary>
        /// <param name="isModifiable">The value to set for the IsModifiable property </param>
        /// <returns>this instance</returns>
        public Parameter WithIsModifiable(bool isModifiable)
        {
            this.isModifiable = isModifiable;
            return this;
        }
            
        // Check to see if IsModifiable property is set
        internal bool IsSetIsModifiable()
        {
            return this.isModifiable.HasValue;      
        }
        public string MinimumEngineVersion
        {
            get { return this.minimumEngineVersion; }
            set { this.minimumEngineVersion = value; }
        }

        /// <summary>
        /// Sets the MinimumEngineVersion property
        /// </summary>
        /// <param name="minimumEngineVersion">The value to set for the MinimumEngineVersion property </param>
        /// <returns>this instance</returns>
        public Parameter WithMinimumEngineVersion(string minimumEngineVersion)
        {
            this.minimumEngineVersion = minimumEngineVersion;
            return this;
        }
            
        // Check to see if MinimumEngineVersion property is set
        internal bool IsSetMinimumEngineVersion()
        {
            return this.minimumEngineVersion != null;       
        }

        /// <summary>
        /// Indicates when to apply parameter updates.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>immediate, pending-reboot</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ApplyMethod
        {
            get { return this.applyMethod; }
            set { this.applyMethod = value; }
        }

        /// <summary>
        /// Sets the ApplyMethod property
        /// </summary>
        /// <param name="applyMethod">The value to set for the ApplyMethod property </param>
        /// <returns>this instance</returns>
        public Parameter WithApplyMethod(string applyMethod)
        {
            this.applyMethod = applyMethod;
            return this;
        }
            
        // Check to see if ApplyMethod property is set
        internal bool IsSetApplyMethod()
        {
            return this.applyMethod != null;        
        }
    }
}
