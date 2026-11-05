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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// An object that contains information about the Amazon Inspector free trial for an account.
    /// </summary>
    public partial class FreeTrialInfo
    {
        /// <summary>
        /// Gets and sets the property CloudProvider. 
        /// <para>
        /// The cloud provider associated with the free trial information.
        /// </para>
        /// </summary>
        public CloudProvider CloudProvider { get; set; }

        /// <summary>
        /// Checks to see if the CloudProvider property is set.
        /// </summary>
        internal bool IsSetCloudProvider() => this.CloudProvider != null;

        /// <summary>
        /// Gets and sets the property End. 
        /// <para>
        /// The date and time that the Amazon Inspector free trail ends for a given account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? End { get; set; }

        /// <summary>
        /// Checks to see if the End property is set.
        /// </summary>
        internal bool IsSetEnd() => this.End.HasValue;

        /// <summary>
        /// Gets and sets the property Start. 
        /// <para>
        /// The date and time that the Amazon Inspector free trail started for a given account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? Start { get; set; }

        /// <summary>
        /// Checks to see if the Start property is set.
        /// </summary>
        internal bool IsSetStart() => this.Start.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The order to sort results by.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FreeTrialStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of scan covered by the Amazon Inspector free trail.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FreeTrialType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
