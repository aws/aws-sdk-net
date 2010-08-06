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
 *  API Version: 2009-11-30
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Get Console Output Result
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2009-11-30/", IsNullable = false)]
    public class GetConsoleOutputResult
    {
        private ConsoleOutput consoleOutputField;

        /// <summary>
        /// Gets and sets the ConsoleOutput property.
        /// Console output
        /// </summary>
        [XmlElementAttribute(ElementName = "ConsoleOutput")]
        public ConsoleOutput ConsoleOutput
        {
            get { return this.consoleOutputField; }
            set { this.consoleOutputField = value; }
        }

        /// <summary>
        /// Sets the ConsoleOutput property
        /// </summary>
        /// <param name="consoleOutput">Console output</param>
        /// <returns>this instance</returns>
        public GetConsoleOutputResult WithConsoleOutput(ConsoleOutput consoleOutput)
        {
            this.consoleOutputField = consoleOutput;
            return this;
        }

        /// <summary>
        /// Checks if ConsoleOutput property is set
        /// </summary>
        /// <returns>true if ConsoleOutput property is set</returns>
        public bool IsSetConsoleOutput()
        {
            return this.consoleOutputField != null;
        }

    }
}
