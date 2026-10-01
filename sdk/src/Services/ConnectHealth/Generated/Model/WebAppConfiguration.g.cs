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

namespace Amazon.ConnectHealth.Model
{
    /// <summary>
    /// Configuration for the Domain web application, including Identity Center settings.
    /// If provided, all fields are required.
    /// </summary>
    public partial class WebAppConfiguration
    {
        /// <summary>
        /// Gets and sets the property EhrRole. 
        /// <para>
        /// ARN of the IAM role used for EHR operations.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string EhrRole { get; set; }

        /// <summary>
        /// Checks to see if the EhrRole property is set.
        /// </summary>
        internal bool IsSetEhrRole() => this.EhrRole != null;

        /// <summary>
        /// Gets and sets the property IdcApplicationId. 
        /// <para>
        /// The Identity Center application ID associated with this Domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string IdcApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the IdcApplicationId property is set.
        /// </summary>
        internal bool IsSetIdcApplicationId() => this.IdcApplicationId != null;

        /// <summary>
        /// Gets and sets the property IdcRegion. 
        /// <para>
        /// The AWS region where Identity Center is configured.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string IdcRegion { get; set; }

        /// <summary>
        /// Checks to see if the IdcRegion property is set.
        /// </summary>
        internal bool IsSetIdcRegion() => this.IdcRegion != null;
    }
}
