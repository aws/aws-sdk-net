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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
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
namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// The settings for ungraceful execution.
    /// </summary>
    public partial class EcsUngraceful
    {
        private int? _minimumSuccessPercentage;

        /// <summary>
        /// Gets and sets the property MinimumSuccessPercentage. 
        /// <para>
        /// The minimum success percentage specified for the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=99)]
        public int? MinimumSuccessPercentage
        {
            get { return this._minimumSuccessPercentage; }
            set { this._minimumSuccessPercentage = value; }
        }

        // Check to see if MinimumSuccessPercentage property is set
        internal bool IsSetMinimumSuccessPercentage()
        {
            return this._minimumSuccessPercentage.HasValue; 
        }

    }
}