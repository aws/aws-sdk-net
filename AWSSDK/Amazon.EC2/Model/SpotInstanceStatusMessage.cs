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
    /// Status details for the Spot Instance request.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class SpotInstanceStatusMessage
    {    
        private string codeField;
        private string updateTimeField;
        private string messageField;

        /// <summary>
        /// The code for the Spot Instance request status.
        /// </summary>
        [XmlElementAttribute(ElementName = "Code")]
        public string Code
        {
            get { return this.codeField; }
            set { this.codeField = value; }
        }

        /// <summary>
        /// Sets the code for the Spot Instance request status.
        /// </summary>
        /// <param name="code">The code for the Spot Instance request status</param>
        /// <returns>this instance</returns>
        public SpotInstanceStatusMessage WithCode(string code)
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
            return this.codeField != null;
        }


        /// <summary>
        /// The time of the most recent update for the status.
        /// </summary>
        [XmlElementAttribute(ElementName = "UpdateTime")]
        public string UpdateTime
        {
            get { return this.updateTimeField; }
            set { this.updateTimeField = value; }
        }

        /// <summary>
        /// Sets the time of the most recent update for the status.
        /// </summary>
        /// <param name="updateTime">The time of the most recent update for the
        /// status.</param>
        /// <returns>this instance</returns>
        public SpotInstanceStatusMessage WithUpdateTime(string updateTime)
        {
            this.updateTimeField = updateTime;
            return this;
        }

        /// <summary>
        /// Checks if UpdateTime property is set
        /// </summary>
        /// <returns>true if UpdateTime property is set</returns>
        public bool IsSetUpdateTime()
        {
            return this.updateTimeField != null;
        }


        /// <summary>
        /// The message for the Spot Instance request status.
        /// </summary>
        [XmlElementAttribute(ElementName = "Message")]
        public string Message
        {
            get { return this.messageField; }
            set { this.messageField = value; }
        }

        /// <summary>
        /// Sets the message for the Spot Instance request status.
        /// </summary>
        /// <param name="message">The message for the Spot Instance request
        /// status.</param>
        /// <returns>this instance</returns>
        public SpotInstanceStatusMessage WithMessage(string message)
        {
            this.messageField = message;
            return this;
        }

        /// <summary>
        /// Checks if Message property is set
        /// </summary>
        /// <returns>true if Message property is set</returns>
        public bool IsSetMessage()
        {
            return this.messageField != null;
        }

    }
}
