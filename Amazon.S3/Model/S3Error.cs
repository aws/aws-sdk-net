/*******************************************************************************
 *  Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */

using System.Xml.Serialization;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Represents an error returned by the S3 service. Exposes 
    /// an error code, a message, a host ID and a request ID for
    /// debugging purposes.
    /// </summary>
    public class S3Error
    {
        #region Private Members

        private string code;
        private string message;
        private string hostId;
        private string requestId;

        #endregion

        #region Code

        /// <summary>
        /// Gets and sets the Code property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Code")]
        public string Code
        {
            get { return this.code; }
            set { this.code = value; }
        }

        #endregion

        #region Message

        /// <summary>
        /// Gets and sets the Message property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Message")]
        public string Message
        {
            get { return this.message; }
            set { this.message = value; }
        }

        #endregion

        #region HostId

        /// <summary>
        /// Gets and sets the HostId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "HostId")]
        public string HostId
        {
            get { return this.hostId; }
            set { this.hostId = value; }
        }

        #endregion

        #region RequestId

        /// <summary>
        /// Gets and sets the RequestId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "RequestId")]
        public string RequestId
        {
            get { return this.requestId; }
            set { this.requestId = value; }
        }

        #endregion
    }
}
