/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Provides information about the GPU accelerators used for jobs processed by a fleet.
    /// </summary>
    public partial class AcceleratorCapabilities
    {
        private AcceleratorCountRange _count;
        private List<AcceleratorSelection> _selections = AWSConfigs.InitializeCollections ? new List<AcceleratorSelection>() : null;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of GPU accelerators specified for worker hosts in this fleet. 
        /// </para>
        /// </summary>
        public AcceleratorCountRange Count
        {
            get { return this._count; }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count != null;
        }

        /// <summary>
        /// Gets and sets the property Selections. 
        /// <para>
        /// A list of accelerator capabilities requested for this fleet. Only Amazon Elastic Compute
        /// Cloud instances that provide these capabilities will be used. For example, if you
        /// specify both L4 and T4 chips, Deadline Cloud will use Amazon EC2 instances that have
        /// either the L4 or the T4 chip installed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AcceleratorSelection> Selections
        {
            get { return this._selections; }
            set { this._selections = value; }
        }

        // Check to see if Selections property is set
        internal bool IsSetSelections()
        {
            return this._selections != null && (this._selections.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}