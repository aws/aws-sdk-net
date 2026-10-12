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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The delivery details for an email or SMS message that Amazon Cognito sent for authentication
    /// or verification.
    /// </summary>
    public partial class CodeDeliveryDetailsType
    {
        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The name of the attribute that Amazon Cognito verifies with the code.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string AttributeName { get; set; }

        /// <summary>
        /// Checks to see if the AttributeName property is set.
        /// </summary>
        internal bool IsSetAttributeName() => this.AttributeName != null;

        /// <summary>
        /// Gets and sets the property DeliveryMedium. 
        /// <para>
        /// The method that Amazon Cognito used to send the code.
        /// </para>
        /// </summary>
        public DeliveryMediumType DeliveryMedium { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryMedium property is set.
        /// </summary>
        internal bool IsSetDeliveryMedium() => this.DeliveryMedium != null;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The email address or phone number destination where Amazon Cognito sent the code.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 131072)]
        public string Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;
    }
}
