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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.MigrationHubConfig.Model
{
    /// <summary>
    /// A home region control is an object that specifies the home region for an account,
    /// with some additional information. It contains a target (always of type <c>ACCOUNT</c>),
    /// an ID, and a time at which the home region was set.
    /// </summary>
    public partial class HomeRegionControl
    {
        /// <summary>
        /// Gets and sets the property ControlId. 
        /// <para>
        /// A unique identifier that's generated for each home region control. It's always a string
        /// that begins with "hrc-" followed by 12 lowercase letters and numbers.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string ControlId { get; set; }

        /// <summary>
        /// Checks to see if the ControlId property is set.
        /// </summary>
        internal bool IsSetControlId() => this.ControlId != null;

        /// <summary>
        /// Gets and sets the property HomeRegion. 
        /// <para>
        /// The AWS Region that's been set as home region. For example, "us-west-2" or "eu-central-1"
        /// are valid home regions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string HomeRegion { get; set; }

        /// <summary>
        /// Checks to see if the HomeRegion property is set.
        /// </summary>
        internal bool IsSetHomeRegion() => this.HomeRegion != null;

        /// <summary>
        /// Gets and sets the property RequestedTime. 
        /// <para>
        /// A timestamp representing the time when the customer called <c>CreateHomeregionControl</c>
        /// and set the home region for the account.
        /// </para>
        /// </summary>
        public DateTime? RequestedTime { get; set; }

        /// <summary>
        /// Checks to see if the RequestedTime property is set.
        /// </summary>
        internal bool IsSetRequestedTime() => this.RequestedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The target parameter specifies the identifier to which the home region is applied,
        /// which is always an <c>ACCOUNT</c>. It applies the home region to the current <c>ACCOUNT</c>.
        /// </para>
        /// </summary>
        public Target Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;
    }
}
