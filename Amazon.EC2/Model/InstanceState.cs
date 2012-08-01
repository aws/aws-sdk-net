/*******************************************************************************
 * Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    ///<summary>
    ///Instance State
    ///</summary>
    [XmlRootAttribute(IsNullable = false)]
    public class InstanceState
    {    
        private Decimal? codeField;
        private string nameField;

        /// <summary>
        /// Gets and sets the Code property.
        /// A 16-bit unsigned integer. The high byte is an
        /// opaque internal value and should be
        /// ignored. The low byte is set
        /// based on the state represented.
        ///
        /// Valid values are: 0 (pending) |
        /// 16 (running) | 32 (shutting-down) |
        /// 48 (terminated) | 64
        /// (stopping) | 80 (stopped)
        /// </summary>
        [XmlElementAttribute(ElementName = "Code")]
        public Decimal Code
        {
            get { return this.codeField.GetValueOrDefault(); }
            set { this.codeField = value; }
        }

        /// <summary>
        /// Sets the Code property
        /// </summary>
        /// <param name="code">A 16-bit unsigned integer. The high byte is an
        /// opaque internal value and should be
        /// ignored. The low byte is set
        /// based on the state represented.
        ///
        /// Valid values are: 0 (pending) |
        /// 16 (running) | 32 (shutting-down) |
        /// 48 (terminated) | 64
        /// (stopping) | 80 (stopped)</param>
        /// <returns>this instance</returns>
        public InstanceState WithCode(Decimal code)
        {
            this.codeField = code;
            return this;
        }

        /// <summary>
        /// Checks if Code property is set
        /// </summary>
        /// <returns>true if Code property is set</returns>
        public bool IsSetCode()
        {
            return this.codeField.HasValue;
        }

        /// <summary>
        /// Gets and sets the Name property.
        /// The current state of the instance.
        ///
        /// Valid values are: pending | running | shutting-down | terminated |
        /// stopping | stopped
        /// </summary>
        [XmlElementAttribute(ElementName = "Name")]
        public string Name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The current state of the instance.
        ///
        /// Valid values are: pending | running | shutting-down | terminated |
        /// stopping | stopped</param>
        /// <returns>this instance</returns>
        public InstanceState WithName(string name)
        {
            this.nameField = name;
            return this;
        }

        /// <summary>
        /// Checks if Name property is set
        /// </summary>
        /// <returns>true if Name property is set</returns>
        public bool IsSetName()
        {
            return this.nameField != null;
        }

    }
}
