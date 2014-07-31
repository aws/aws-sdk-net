/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Specifies whether the <a>PutScalingPolicy</a> <code>ScalingAdjustment</code> parameter
    /// is an absolute number or a percentage of the current capacity.
    /// </summary>
    public partial class AdjustmentType
    {
        private string _adjustmentType;


        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// A policy adjustment type. Valid values are <code>ChangeInCapacity</code>, <code>ExactCapacity</code>,
        /// and <code>PercentChangeInCapacity</code>.
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._adjustmentType; }
            set { this._adjustmentType = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._adjustmentType != null;
        }

    }
}