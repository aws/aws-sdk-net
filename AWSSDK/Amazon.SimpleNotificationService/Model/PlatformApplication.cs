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
 *  API Version: 2010-03-31
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// The Platform application object.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://sns.amazonaws.com/doc/2010-03-31/", IsNullable = false)]
    public class PlatformApplication
    {
        
        private string platformApplicationArnField;
        private List<PlatformApplicationAttribute> attributes;

        /// <summary>
        ///  The Platform Application ARN.
        /// </summary>
        [XmlElementAttribute(ElementName = "PlatformApplicationArn")]
        public string PlatformApplicationArn
        {
            get { return this.platformApplicationArnField; }
            set { this.platformApplicationArnField = value; }
        }

        /// <summary>
        /// Sets the PlatformApplicationArn.
        /// </summary>
        /// <param name="platformApplicationArn">The Platform Application ARN.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PlatformApplication WithPlatformApplicationArn(string platformApplicationArn)
        {
            this.platformApplicationArnField = platformApplicationArn;
            return this;
        }

        /// <summary>
        /// Checks if PlatformApplicationArn property is set
        /// </summary>
        /// <returns>true if PlatformApplicationArn property is set</returns>
        public bool IsSetPlatformApplicationArn()
        {
            return this.platformApplicationArnField != null;
        }


        /// <summary>
        /// Gets or sets the attributes.
        /// </summary>
        /// <value>The attributes.</value>
        [XmlElementAttribute(ElementName = "Attributes")]
        public List<PlatformApplicationAttribute> Attributes
        {
            get { return this.attributes; }
            set { this.attributes = value; }
        }

        /// <summary>
        /// Determines whether the target <see cref="P:Attributes"/> is set in this request.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if any attributes are set; otherwise, <c>false</c>.
        /// </returns>
        public bool IsSetAttributes()
        {
            return this.attributes != null;
        }
    }
}
