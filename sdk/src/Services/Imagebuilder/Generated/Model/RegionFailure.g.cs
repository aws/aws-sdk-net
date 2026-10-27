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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Contains details about a distribution or image configuration failure for a single
    /// Region.
    /// </summary>
    public partial class RegionFailure
    {
        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The error message for the failure in the Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 384000)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property ImageConfigurationStep. 
        /// <para>
        /// The image configuration step where the failure occurred. Image Builder sets this property
        /// when the failure happened during post-distribution configuration, such as launch template
        /// updates or virtual machine (VM) export. This property doesn't appear for failures
        /// that occurred while Image Builder copied the image to the Region.
        /// </para>
        /// </summary>
        public ImageConfigurationStep ImageConfigurationStep { get; set; }

        /// <summary>
        /// Checks to see if the ImageConfigurationStep property is set.
        /// </summary>
        internal bool IsSetImageConfigurationStep() => this.ImageConfigurationStep != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Region where the failure occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The failure status for the Region. Indicates whether the process failed, was canceled,
        /// or timed out.
        /// </para>
        /// </summary>
        public RegionFailureStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetAccountId. 
        /// <para>
        /// The account ID of the account that the image was distributed to in the Region.
        /// </para>
        /// </summary>
        public string TargetAccountId { get; set; }

        /// <summary>
        /// Checks to see if the TargetAccountId property is set.
        /// </summary>
        internal bool IsSetTargetAccountId() => this.TargetAccountId != null;
    }
}
