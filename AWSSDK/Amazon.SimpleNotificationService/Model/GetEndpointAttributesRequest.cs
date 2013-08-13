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
    /// Retrieves the endpoint attributes for a device on one of the supported push notification services, such as GCM and APNS. 
    /// </summary>
    /// <remarks>
    /// For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS Mobile Push Notifications</a>.
    /// </remarks>
    [XmlRootAttribute(Namespace = "http://sns.amazonaws.com/doc/2010-03-31/", IsNullable = false)]
    public class GetEndpointAttributesRequest : SNSRequest
    {
        
        private string endpointArn;

        /// <summary>
        /// Gets or sets the endpoint ARN.
        /// </summary>
        /// <value>The name.</value>
        [XmlElementAttribute(ElementName = "EndpointArn")]
        public string EndpointArn
        {
            get { return this.endpointArn; }
            set { this.endpointArn = value; }
        }

        /// <summary>
        /// Determines whether the target <see cref="P:Platform"/> property is set.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if the target platform is set; otherwise, <c>false</c>.
        /// </returns>
        public bool IsSetEndpointArn()
        {
            return !String.IsNullOrEmpty(this.endpointArn);
        }
    }
}
