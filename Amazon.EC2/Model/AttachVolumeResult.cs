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
    /// Attach Volume Result
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2009-11-30/", IsNullable = false)]
    public class AttachVolumeResult
    {
        private Attachment attachmentField;

        /// <summary>
        /// Gets and sets the Attachment property.
        /// Volume Attachment
        /// </summary>
        [XmlElementAttribute(ElementName = "Attachment")]
        public Attachment Attachment
        {
            get { return this.attachmentField; }
            set { this.attachmentField = value; }
        }

        /// <summary>
        /// Sets the Attachment property
        /// </summary>
        /// <param name="attachment">Volume Attachment</param>
        /// <returns>this instance</returns>
        public AttachVolumeResult WithAttachment(Attachment attachment)
        {
            this.attachmentField = attachment;
            return this;
        }

        /// <summary>
        /// Checks if Attachment property is set
        /// </summary>
        /// <returns>true if Attachment property is set</returns>
        public bool IsSetAttachment()
        {
            return this.attachmentField != null;
        }

    }
}
