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
using System.IO;
using Amazon.Runtime;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// The resulting information about the modified Reserved Instances.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class ReservedInstancesModificationResult
    {
        
        private string reservedInstancesIdField;
        private ReservedInstancesConfiguration targetConfigurationField;

        /// <summary>
        /// The ID for the Reserved Instances created as part of the modification request.
        ///  
        /// </summary>
        [XmlElementAttribute(ElementName = "ReservedInstancesId")]
        public string ReservedInstancesId
        {
            get { return this.reservedInstancesIdField; }
            set { this.reservedInstancesIdField = value; }
        }

        // Check to see if ReservedInstancesId property is set
        internal bool IsSetReservedInstancesId()
        {
            return this.reservedInstancesIdField != null;
        }

        /// <summary>
        /// The configuration settings for the modified Reserved Instances.
        ///  
        /// </summary>
        [XmlElementAttribute(ElementName = "ReservedInstancesConfiguration")]
        public ReservedInstancesConfiguration TargetConfiguration
        {
            get { return this.targetConfigurationField; }
            set { this.targetConfigurationField = value; }
        }

        // Check to see if TargetConfiguration property is set
        internal bool IsSetTargetConfiguration()
        {
            return this.targetConfigurationField != null;
        }
    }
}
