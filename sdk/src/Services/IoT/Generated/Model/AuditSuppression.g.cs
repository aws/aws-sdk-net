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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Filters out specific findings of a Device Defender audit.
    /// </summary>
    public partial class AuditSuppression
    {
        /// <summary>
        /// Gets and sets the property CheckName.
        /// </summary>
        [AWSProperty(Required = true)]
        public string CheckName { get; set; }

        /// <summary>
        /// Checks to see if the CheckName property is set.
        /// </summary>
        internal bool IsSetCheckName() => this.CheckName != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description of the audit suppression. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExpirationDate. 
        /// <para>
        ///  The expiration date (epoch timestamp in seconds) that you want the suppression to
        /// adhere to. 
        /// </para>
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationDate property is set.
        /// </summary>
        internal bool IsSetExpirationDate() => this.ExpirationDate.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceIdentifier.
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceIdentifier ResourceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ResourceIdentifier property is set.
        /// </summary>
        internal bool IsSetResourceIdentifier() => this.ResourceIdentifier != null;

        /// <summary>
        /// Gets and sets the property SuppressIndefinitely. 
        /// <para>
        ///  Indicates whether a suppression should exist indefinitely or not. 
        /// </para>
        /// </summary>
        public bool? SuppressIndefinitely { get; set; }

        /// <summary>
        /// Checks to see if the SuppressIndefinitely property is set.
        /// </summary>
        internal bool IsSetSuppressIndefinitely() => this.SuppressIndefinitely.HasValue;
    }
}
