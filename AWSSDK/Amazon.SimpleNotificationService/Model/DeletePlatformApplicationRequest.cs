/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2010-05-02
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Deletes a platform application object for one of the supported push notification services, 
    /// such as APNS and GCM.
    /// </summary>
    /// <remarks>
    /// For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS Mobile Push Notifications</a>.
    /// </remarks>
    [XmlRootAttribute(Namespace = "http://sns.amazonaws.com/doc/2010-03-31/", IsNullable = false)]
    public class DeletePlatformApplicationRequest : SNSRequest
    {
        
        private string platformApplicationArn;

        /// <summary>
        /// Gets or sets the platform application arn.
        /// </summary>
        /// <value>
        /// The platform application arn.
        /// </value>
        [XmlElementAttribute(ElementName = "PlatformApplicationArn")]
        public string PlatformApplicationArn
        {
            get { return this.platformApplicationArn; }
            set { this.platformApplicationArn = value; }
        }

        /// <summary>
        /// Determines whether the <see cref="P:PlatformApplicationArn"/> property is set.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if the platform application ARN is set; otherwise, <c>false</c>.
        /// </returns>
        public bool IsSetPlatformApplicationArn()
        {
            return !String.IsNullOrEmpty(this.platformApplicationArn);
        }

        /// <summary>
        /// Modifies the platform application ARN in this request.
        /// </summary>
        /// <param name="platformApplicationArn">The platform application arn.</param>
        /// <returns>This instance.</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeletePlatformApplicationRequest WithPlatformApplicationArn(string platformApplicationArn)
        {
            this.platformApplicationArn = platformApplicationArn;
            return this;
        }
    }
}
