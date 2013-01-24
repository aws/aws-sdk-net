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
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Instance console output
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class ConsoleOutput
    {    
        private string instanceIdField;
        private string timestampField;
        private string outputField;

        /// <summary>
        /// The instance ID.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceId")]
        public string InstanceId
        {
            get { return this.instanceIdField; }
            set { this.instanceIdField = value; }
        }

        /// <summary>
        /// Sets the instance ID.
        /// </summary>
        /// <param name="instanceId">The instance ID.</param>
        /// <returns>this instance</returns>
        public ConsoleOutput WithInstanceId(string instanceId)
        {
            this.instanceIdField = instanceId;
            return this;
        }

        /// <summary>
        /// Checks if InstanceId property is set
        /// </summary>
        /// <returns>true if InstanceId property is set</returns>
        public bool IsSetInstanceId()
        {
            return this.instanceIdField != null;
        }

        /// <summary>
        /// The time the output was last updated.
        /// </summary>
        [XmlElementAttribute(ElementName = "Timestamp")]
        public string Timestamp
        {
            get { return this.timestampField; }
            set { this.timestampField = value; }
        }

        /// <summary>
        /// Sets the time the output was last updated.
        /// </summary>
        /// <param name="timestamp">The time the output was last updated.</param>
        /// <returns>this instance</returns>
        public ConsoleOutput WithTimestamp(string timestamp)
        {
            this.timestampField = timestamp;
            return this;
        }

        /// <summary>
        /// Checks if Timestamp property is set
        /// </summary>
        /// <returns>true if Timestamp property is set</returns>
        public bool IsSetTimestamp()
        {
            return this.timestampField != null;
        }

        /// <summary>
        /// The console output, Base64 encoded.
        /// </summary>
        [XmlElementAttribute(ElementName = "Output")]
        public string Output
        {
            get { return this.outputField; }
            set { this.outputField = value; }
        }

        /// <summary>
        /// Sets the console output, Base64 encoded.
        /// </summary>
        /// <param name="output">The console output, Base64 encoded.</param>
        /// <returns>this instance</returns>
        public ConsoleOutput WithOutput(string output)
        {
            this.outputField = output;
            return this;
        }

        /// <summary>
        /// Checks if Output property is set
        /// </summary>
        /// <returns>true if Output property is set</returns>
        public bool IsSetOutput()
        {
            return this.outputField != null;
        }

    }
}
