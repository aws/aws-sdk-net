/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2009-10-16
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.RDS.Model
{
    ///<summary>
    ///Information about the DB Parameter.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://rds.amazonaws.com/admin/2009-10-16/", IsNullable = false)]
    public class Parameter
    {
        private string parameterNameField;
        private string parameterValueField;
        private string descriptionField;
        private string sourceField;
        private string applyTypeField;
        private string dataTypeField;
        private string allowedValuesField;
        private bool? isModifiableField;
        private string applyMethodField;

        /// <summary>
        /// Gets and sets the ParameterName property.
        /// The name of the parameter.
        /// </summary>
        [XmlElementAttribute(ElementName = "ParameterName")]
        public string ParameterName
        {
            get { return this.parameterNameField ; }
            set { this.parameterNameField= value; }
        }

        /// <summary>
        /// Sets the ParameterName property
        /// </summary>
        /// <param name="parameterName">The name of the parameter.</param>
        /// <returns>this instance</returns>
        public Parameter WithParameterName(string parameterName)
        {
            this.parameterNameField = parameterName;
            return this;
        }

        /// <summary>
        /// Checks if ParameterName property is set
        /// </summary>
        /// <returns>true if ParameterName property is set</returns>
        public bool IsSetParameterName()
        {
            return  this.parameterNameField != null;
        }

        /// <summary>
        /// Gets and sets the ParameterValue property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ParameterValue")]
        public string ParameterValue
        {
            get { return this.parameterValueField ; }
            set { this.parameterValueField= value; }
        }

        /// <summary>
        /// Sets the ParameterValue property
        /// </summary>
        /// <param name="parameterValue">ParameterValue property</param>
        /// <returns>this instance</returns>
        public Parameter WithParameterValue(string parameterValue)
        {
            this.parameterValueField = parameterValue;
            return this;
        }

        /// <summary>
        /// Checks if ParameterValue property is set
        /// </summary>
        /// <returns>true if ParameterValue property is set</returns>
        public bool IsSetParameterValue()
        {
            return  this.parameterValueField != null;
        }

        /// <summary>
        /// Gets and sets the Description property.
        /// A description of the parameter.
        /// </summary>
        [XmlElementAttribute(ElementName = "Description")]
        public string Description
        {
            get { return this.descriptionField ; }
            set { this.descriptionField= value; }
        }

        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">A description of the parameter.</param>
        /// <returns>this instance</returns>
        public Parameter WithDescription(string description)
        {
            this.descriptionField = description;
            return this;
        }

        /// <summary>
        /// Checks if Description property is set
        /// </summary>
        /// <returns>true if Description property is set</returns>
        public bool IsSetDescription()
        {
            return  this.descriptionField != null;
        }

        /// <summary>
        /// Gets and sets the Source property.
        /// Indicates the source of the parameter value. User indicates that you set this value, EngineDefault indicates it
        /// is the default value specified by the database engine, and System indicates that it is a value optimized based on
        /// the DBInstanceClass or AllocatedStorage of the DB Instance. Valid Values: user | system | engine-default.
        /// </summary>
        [XmlElementAttribute(ElementName = "Source")]
        public string Source
        {
            get { return this.sourceField ; }
            set { this.sourceField= value; }
        }

        /// <summary>
        /// Sets the Source property
        /// </summary>
        /// <param name="source">Indicates the source of the parameter value. User indicates that you set this value, EngineDefault indicates it
        /// is the default value specified by the database engine, and System indicates that it is a value optimized based on
        /// the DBInstanceClass or AllocatedStorage of the DB Instance. Valid Values: user | system | engine-default.</param>
        /// <returns>this instance</returns>
        public Parameter WithSource(string source)
        {
            this.sourceField = source;
            return this;
        }

        /// <summary>
        /// Checks if Source property is set
        /// </summary>
        /// <returns>true if Source property is set</returns>
        public bool IsSetSource()
        {
            return  this.sourceField != null;
        }

        /// <summary>
        /// Gets and sets the ApplyType property.
        /// The engine specific parameter type. Valid Values: static | dynamic.
        /// </summary>
        [XmlElementAttribute(ElementName = "ApplyType")]
        public string ApplyType
        {
            get { return this.applyTypeField ; }
            set { this.applyTypeField= value; }
        }

        /// <summary>
        /// Sets the ApplyType property
        /// </summary>
        /// <param name="applyType">The engine specific parameter type. Valid Values: static | dynamic.</param>
        /// <returns>this instance</returns>
        public Parameter WithApplyType(string applyType)
        {
            this.applyTypeField = applyType;
            return this;
        }

        /// <summary>
        /// Checks if ApplyType property is set
        /// </summary>
        /// <returns>true if ApplyType property is set</returns>
        public bool IsSetApplyType()
        {
            return  this.applyTypeField != null;
        }

        /// <summary>
        /// Gets and sets the DataType property.
        /// The valid data type for the parameter. Valid Values: integer | string | boolean.
        /// </summary>
        [XmlElementAttribute(ElementName = "DataType")]
        public string DataType
        {
            get { return this.dataTypeField ; }
            set { this.dataTypeField= value; }
        }

        /// <summary>
        /// Sets the DataType property
        /// </summary>
        /// <param name="dataType">The valid data type for the parameter. Valid Values: integer | string | boolean.</param>
        /// <returns>this instance</returns>
        public Parameter WithDataType(string dataType)
        {
            this.dataTypeField = dataType;
            return this;
        }

        /// <summary>
        /// Checks if DataType property is set
        /// </summary>
        /// <returns>true if DataType property is set</returns>
        public bool IsSetDataType()
        {
            return  this.dataTypeField != null;
        }

        /// <summary>
        /// Gets and sets the AllowedValues property.
        /// The valid range of values for this parameter.
        /// </summary>
        [XmlElementAttribute(ElementName = "AllowedValues")]
        public string AllowedValues
        {
            get { return this.allowedValuesField ; }
            set { this.allowedValuesField= value; }
        }

        /// <summary>
        /// Sets the AllowedValues property
        /// </summary>
        /// <param name="allowedValues">The valid range of values for this parameter.</param>
        /// <returns>this instance</returns>
        public Parameter WithAllowedValues(string allowedValues)
        {
            this.allowedValuesField = allowedValues;
            return this;
        }

        /// <summary>
        /// Checks if AllowedValues property is set
        /// </summary>
        /// <returns>true if AllowedValues property is set</returns>
        public bool IsSetAllowedValues()
        {
            return  this.allowedValuesField != null;
        }

        /// <summary>
        /// Gets and sets the IsModifiable property.
        /// Indicates whether the parameter can be modified. Some parameters have security or operational
        /// implications that prevent them from being changed.
        /// </summary>
        [XmlElementAttribute(ElementName = "IsModifiable")]
        public bool IsModifiable
        {
            get { return this.isModifiableField.GetValueOrDefault() ; }
            set { this.isModifiableField= value; }
        }

        /// <summary>
        /// Sets the IsModifiable property
        /// </summary>
        /// <param name="isModifiable">Indicates whether the parameter can be modified. Some parameters have security or operational
        /// implications that prevent them from being changed.</param>
        /// <returns>this instance</returns>
        public Parameter WithIsModifiable(bool isModifiable)
        {
            this.isModifiableField = isModifiable;
            return this;
        }

        /// <summary>
        /// Checks if IsModifiable property is set
        /// </summary>
        /// <returns>true if IsModifiable property is set</returns>
        public bool IsSetIsModifiable()
        {
            return  this.isModifiableField.HasValue;
        }

        /// <summary>
        /// Gets and sets the ApplyMethod property.
        /// Indicates when to apply parameter updates. Valid Values for MySQL5.1: immediate | pending-reboot
        /// </summary>
        [XmlElementAttribute(ElementName = "ApplyMethod")]
        public string ApplyMethod
        {
            get { return this.applyMethodField ; }
            set { this.applyMethodField= value; }
        }

        /// <summary>
        /// Sets the ApplyMethod property
        /// </summary>
        /// <param name="applyMethod">Indicates when to apply parameter updates. Valid Values for MySQL5.1: immediate | pending-reboot</param>
        /// <returns>this instance</returns>
        public Parameter WithApplyMethod(string applyMethod)
        {
            this.applyMethodField = applyMethod;
            return this;
        }

        /// <summary>
        /// Checks if ApplyMethod property is set
        /// </summary>
        /// <returns>true if ApplyMethod property is set</returns>
        public bool IsSetApplyMethod()
        {
            return  this.applyMethodField != null;
        }

    }
}
