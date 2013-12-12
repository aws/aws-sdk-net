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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// <para> This data type is used as a request parameter in the ModifyDBParameterGroup and ResetDBParameterGroup actions. </para> <para>This
    /// data type is used as a response element in the DescribeEngineDefaultParameters and DescribeDBParameters actions.</para>
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
        private ApplyMethod applyMethod;


        /// <summary>
        /// Specifies the name of the parameter.
        ///  
        /// </summary>
        public string ParameterName
        {
            get { return this.parameterName; }
            set { this.parameterName = value; }
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

        // Check to see if AllowedValues property is set
        internal bool IsSetAllowedValues()
        {
            return this.allowedValues != null;
        }

        /// <summary>
        /// Indicates whether (<c>true</c>) or not (<c>false</c>) the parameter can be modified. Some parameters have security or operational
        /// implications that prevent them from being changed.
        ///  
        /// </summary>
        public bool IsModifiable
        {
            get { return this.isModifiable ?? default(bool); }
            set { this.isModifiable = value; }
        }

        // Check to see if IsModifiable property is set
        internal bool IsSetIsModifiable()
        {
            return this.isModifiable.HasValue;
        }

        /// <summary>
        /// The earliest engine version to which the parameter can apply.
        ///  
        /// </summary>
        public string MinimumEngineVersion
        {
            get { return this.minimumEngineVersion; }
            set { this.minimumEngineVersion = value; }
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
        public ApplyMethod ApplyMethod
        {
            get { return this.applyMethod; }
            set { this.applyMethod = value; }
        }

        // Check to see if ApplyMethod property is set
        internal bool IsSetApplyMethod()
        {
            return this.applyMethod != null;
        }
    }
}
