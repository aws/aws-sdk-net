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

namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Container for the parameters to the PutMLConfiguration operation. Assigns information
    /// about an ML configuration.
    /// </summary>
    public partial class PutMLConfigurationRequest : AmazonCleanRoomsMLRequest
    {
        /// <summary>
        /// Gets and sets the property DefaultOutputLocation. 
        /// <para>
        /// The default Amazon S3 location where ML output is stored for the specified member.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MLOutputConfiguration DefaultOutputLocation { get; set; }

        /// <summary>
        /// Checks to see if the DefaultOutputLocation property is set.
        /// </summary>
        internal bool IsSetDefaultOutputLocation() => this.DefaultOutputLocation != null;

        /// <summary>
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        /// The membership ID of the member that is being configured.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string MembershipIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the MembershipIdentifier property is set.
        /// </summary>
        internal bool IsSetMembershipIdentifier() => this.MembershipIdentifier != null;
    }
}
