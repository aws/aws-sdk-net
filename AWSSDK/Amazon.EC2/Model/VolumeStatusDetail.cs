/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.IO;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Volume Status Detail
    /// </summary>
    public class VolumeStatusDetail
    {
        private string nameField;
        private string statusField;

        /// <summary>
        /// The name of the volume's status.
        /// </summary>
        public string Name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }
        /// <summary>
        /// Checks if Name property is set
        /// </summary>
        /// <returns>true if Name property is set</returns>
        public bool IsSetName()
        {
            return this.nameField != null;
        }
        /// <summary>
        /// Sets the name of the volume's status.
        /// </summary>
        /// <param name="name">The new name</param>
        /// <returns>this instance</returns>
        public VolumeStatusDetail WithName(string name)
        {
            this.nameField = name;
            return this;
        }

        /// <summary>
        /// The value of the volume's status
        /// </summary>
        public string Status
        {
            get { return this.statusField; }
            set { this.statusField = value; }
        }
        /// <summary>
        /// Checks if Status property is set
        /// </summary>
        /// <returns>true if Status property is set</returns>
        public bool IsSetStatus()
        {
            return this.statusField != null;
        }
        /// <summary>
        /// Sets the value of the volume's status
        /// </summary>
        /// <param name="status">The new status</param>
        /// <returns>this instance</returns>
        public VolumeStatusDetail WithStatus(string status)
        {
            this.statusField = status;
            return this;
        }
    }
}
