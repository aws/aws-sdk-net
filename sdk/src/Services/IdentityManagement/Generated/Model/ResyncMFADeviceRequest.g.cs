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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the ResyncMFADevice operation. Synchronizes the specified
    /// MFA device with its IAM resource object on the Amazon Web Services servers. <para>
    /// For more information about creating and working with virtual MFA devices, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_VirtualMFA.html">Using
    /// a virtual MFA device</a> in the <i>IAM User Guide</i>. </para>
    /// </summary>
    public partial class ResyncMFADeviceRequest : AmazonIdentityManagementServiceRequest
    {
        /// <summary>
        /// Gets and sets the property AuthenticationCode1. 
        /// <para>
        /// An authentication code emitted by the device.
        /// </para>
        ///  
        /// <para>
        /// The format for this parameter is a sequence of six digits.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 6, Max = 6)]
        public string AuthenticationCode1 { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationCode1 property is set.
        /// </summary>
        internal bool IsSetAuthenticationCode1() => this.AuthenticationCode1 != null;

        /// <summary>
        /// Gets and sets the property AuthenticationCode2. 
        /// <para>
        /// A subsequent authentication code emitted by the device.
        /// </para>
        ///  
        /// <para>
        /// The format for this parameter is a sequence of six digits.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 6, Max = 6)]
        public string AuthenticationCode2 { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationCode2 property is set.
        /// </summary>
        internal bool IsSetAuthenticationCode2() => this.AuthenticationCode2 != null;

        /// <summary>
        /// Gets and sets the property SerialNumber. 
        /// <para>
        /// Serial number that uniquely identifies the MFA device.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex
        /// pattern</a>) a string of characters consisting of upper and lowercase alphanumeric
        /// characters with no spaces. You can also include any of the following characters: _+=,.@-
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 9, Max = 256)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Checks to see if the SerialNumber property is set.
        /// </summary>
        internal bool IsSetSerialNumber() => this.SerialNumber != null;

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the user whose MFA device you want to resynchronize.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex
        /// pattern</a>) a string of characters consisting of upper and lowercase alphanumeric
        /// characters with no spaces. You can also include any of the following characters: _+=,.@-
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string UserName { get; set; }

        /// <summary>
        /// Checks to see if the UserName property is set.
        /// </summary>
        internal bool IsSetUserName() => this.UserName != null;
    }
}
