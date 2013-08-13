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
    /// Cancels an active conversion task.
    /// The task can be the import of an instance or volume.
    /// </summary>
    /// <remarks>
    /// The command removes all artifacts of the conversion, including a partially uploaded volume or instance.
    /// If the conversion is complete or is in the process of transferring the final disk image,
    /// the command fails and returns an exception.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class CancelConversionTaskRequest : EC2Request
    {    
        private string conversionTaskIdField;

        /// <summary>
        /// The ID of the task you want to cancel.
        /// </summary>
        [XmlElementAttribute(ElementName = "ConversionTaskId")]
        public string ConversionTaskId
        {
            get { return this.conversionTaskIdField; }
            set { this.conversionTaskIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the task you want to cancel.
        /// </summary>
        /// <param name="conversionTaskId">The ID of the task you want to cancel.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CancelConversionTaskRequest WithConversionTaskId(string conversionTaskId)
        {
            this.conversionTaskIdField = conversionTaskId;
            return this;
        }

        /// <summary>
        /// Checks if ConversionTaskId property is set
        /// </summary>
        /// <returns>true if ConversionTaskId property is set</returns>
        public bool IsSetConversionTaskId()
        {
            return this.conversionTaskIdField != null;
        }

    }
}
