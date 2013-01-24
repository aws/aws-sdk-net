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
    /// Describes your conversion tasks.
    /// For more information, go to Importing Your Virtual Machines and Volumes into Amazon EC2 in the Amazon Elastic Compute Cloud User Guide.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class DescribeConversionTasksRequest
    {    
        private List<string> conversionTaskIdField;

        /// <summary>
        /// One or more conversion task IDs.
        /// </summary>
        [XmlElementAttribute(ElementName = "ConversionTaskId")]
        public List<string> ConversionTaskId
        {
            get
            {
                if (this.conversionTaskIdField == null)
                {
                    this.conversionTaskIdField = new List<string>();
                }
                return this.conversionTaskIdField;
            }
            set { this.conversionTaskIdField = value; }
        }

        /// <summary>
        /// Sets conversion task IDs.
        /// </summary>
        /// <param name="list">A list of conversion tasks.</param>
        /// <returns>this instance</returns>
        public DescribeConversionTasksRequest WithConversionTaskId(params string[] list)
        {
            foreach (string item in list)
            {
                ConversionTaskId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if ConversionTaskId property is set
        /// </summary>
        /// <returns>true if ConversionTaskId property is set</returns>
        public bool IsSetConversionTaskId()
        {
            return (ConversionTaskId.Count > 0);
        }

    }
}
