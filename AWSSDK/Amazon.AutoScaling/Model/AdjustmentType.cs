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
    /// Specifies whether the <a>PutScalingPolicy</a>             <code>ScalingAdjustment</code>
    /// parameter is             an absolute number or a percentage of the current       
    ///     capacity.
    /// </summary>
    public partial class AdjustmentType
    {
        private string _adjustmentType;


        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A policy adjustment type. Valid values are <code>ChangeInCapacity</code>,        
        ///    <code>ExactCapacity</code>, and <code>PercentChangeInCapacity</code>.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._adjustmentType; }
            set { this._adjustmentType = value; }
        }


        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="adjustmentType">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AdjustmentType WithName(string adjustmentType)
        {
            this._adjustmentType = adjustmentType;
            return this;
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._adjustmentType != null;
        }

    }
}