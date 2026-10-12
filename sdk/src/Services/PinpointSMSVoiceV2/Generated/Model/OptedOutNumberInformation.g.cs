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

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// The information for an opted out number in an Amazon Web Services account.
    /// </summary>
    public partial class OptedOutNumberInformation
    {
        /// <summary>
        /// Gets and sets the property EndUserOptedOut. 
        /// <para>
        /// This is set to true if it was the end recipient that opted out.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? EndUserOptedOut { get; set; }

        /// <summary>
        /// Checks to see if the EndUserOptedOut property is set.
        /// </summary>
        internal bool IsSetEndUserOptedOut() => this.EndUserOptedOut.HasValue;

        /// <summary>
        /// Gets and sets the property OptedOutNumber. 
        /// <para>
        /// The phone number that is opted out.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public string OptedOutNumber { get; set; }

        /// <summary>
        /// Checks to see if the OptedOutNumber property is set.
        /// </summary>
        internal bool IsSetOptedOutNumber() => this.OptedOutNumber != null;

        /// <summary>
        /// Gets and sets the property OptedOutTimestamp. 
        /// <para>
        /// The time that the op tout occurred, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? OptedOutTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the OptedOutTimestamp property is set.
        /// </summary>
        internal bool IsSetOptedOutTimestamp() => this.OptedOutTimestamp.HasValue;
    }
}
