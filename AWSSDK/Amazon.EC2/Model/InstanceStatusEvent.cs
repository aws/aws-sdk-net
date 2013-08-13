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
    ///<summary>
    /// Details of a status event for an instance
    ///</summary>
    [XmlRootAttribute(IsNullable = false)]
    public class InstanceStatusEvent
    {
        private string codeField;
        private string descriptionField;
        private string notBeforeField;
        private string notAfterField;

        /// <summary>
        /// The associated code of the event.
        /// Valid values: instance-reboot | system-reboot | instance-retirement.
        /// </summary>
        [XmlElement(ElementName = "Code")]
        public string Code
        {
            get { return this.codeField; }
            set { this.codeField = value; }
        }

        /// <summary>
        /// Sets the associated code for the event. 
        /// </summary>
        /// <param name="code">Valid parameters are instance-reboot|system-reboot|instance-retirement</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceStatusEvent WithCode(string code)
        {
            this.codeField = code;
            return this;
        }

        /// <summary>
        /// Checks if the Code property is set.
        /// </summary>
        /// <returns>true of the Code property is set</returns>
        public bool IsSetCode()
        {
            return this.codeField != null;
        }

        /// <summary>
        /// A description of the event.
        /// </summary>
        [XmlElement(ElementName = "Description")]
        public string Description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <summary>
        /// Sets a description for the event.
        /// </summary>
        /// <param name="description">Event description</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceStatusEvent WithDescription(string description)
        {
            this.descriptionField = description;
            return this;
        }

        /// <summary>
        /// Checks if the Description property is set.
        /// </summary>
        /// <returns>true if the Description property is set</returns>
        public bool IsSetDescription()
        {
            return this.descriptionField != null;
        }

        /// <summary>
        /// The earliest scheduled start time for the event.
        /// </summary>
        [XmlElement(ElementName = "NotBefore")]
        public string NotBefore
        {
            get { return this.notBeforeField; }
            set { this.notBeforeField = value; }
        }

        /// <summary>
        /// Sets the earliest scheduled start time for the event.
        /// </summary>
        /// <param name="notBefore">Scheduled start time</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceStatusEvent WithNotBefore(string notBefore)
        {
            this.notBeforeField = notBefore;
            return this;
        }

        /// <summary>
        /// Checks if the NotBefore property is set
        /// </summary>
        /// <returns>true if the NotBefore property is set</returns>
        public bool IsSetNotBefore()
        {
            return this.notBeforeField != null;
        }

        /// <summary>
        /// The latest scheduled end time for the event.
        /// </summary>
        [XmlElement(ElementName = "NotAfter")]
        public string NotAfter
        {
            get { return this.notAfterField; }
            set { this.notAfterField = value; }
        }

        /// <summary>
        /// Sets the latest scheduled end time for the event.
        /// </summary>
        /// <param name="notAfter">Scheduled end time</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InstanceStatusEvent WithNotAfter(string notAfter)
        {
            this.notAfterField = notAfter;
            return this;
        }

        /// <summary>
        /// Checks if the NotAfter property is set.
        /// </summary>
        /// <returns>true if the NotAfter property is set</returns>
        public bool IsSetNotAfter()
        {
            return this.notAfterField != null;
        }

    }
}
