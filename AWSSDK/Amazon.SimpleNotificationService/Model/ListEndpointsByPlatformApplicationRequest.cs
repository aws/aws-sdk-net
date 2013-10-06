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
 *  API Version: 2010-03-31
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Lists the endpoints and endpoint attributes for devices in a supported push notification service, such as GCM and APNS.
    /// </summary>
    /// <remarks>
    /// The results for this method are paginated and return a limited list of endpoints, up to 100.
    /// If additional records are available after the first page results, then a NextToken string will be returned. 
    /// To receive the next page, you call this method again using the NextToken string received from the previous call. 
    /// When there are no more records to return, NextToken will be null.
    /// For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS Mobile Push Notifications</a>.
    /// </remarks>
    [XmlRootAttribute(Namespace = "http://sns.amazonaws.com/doc/2010-03-31/", IsNullable = false)]
    public class ListEndpointsByPlatformApplicationRequest : SNSRequest
    {
        
        private string platformApplicationArnField;
        private string nextTokenField;

        /// <summary>
        /// The Platform Application ARN.
        /// </summary>
        [XmlElementAttribute(ElementName = "PlatformApplicationArn")]
        public string PlatformApplicationArn
        {
            get { return this.platformApplicationArnField; }
            set { this.platformApplicationArnField = value; }
        }

        /// <summary>
        /// Sets the PlatformApplicationArn.
        /// </summary>
        /// <param name="platformApplicationArn"> .</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListEndpointsByPlatformApplicationRequest WithPlatformApplicationArn(string platformApplicationArn)
        {
            this.platformApplicationArnField = platformApplicationArn;
            return this;
        }

        /// <summary>
        /// Checks if PlatformApplicationArn property is set
        /// </summary>
        /// <returns>true if PlatformApplicationArn property is set</returns>
        public bool IsSetPlatformApplicationArn()
        {
            return this.platformApplicationArnField != null;
        }

        /// <summary>
        /// NextToken string is used when calling ListEndpointsByPlatformApplication method to retrieve additional records that are available after the first page results.
        /// </summary>
        [XmlElementAttribute(ElementName = "NextToken")]
        public string NextToken
        {
            get { return this.nextTokenField; }
            set { this.nextTokenField = value; }
        }

        /// <summary>
        /// Sets the NextToken.
        /// </summary>
        /// <param name="nextToken"> .</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListEndpointsByPlatformApplicationRequest WithNextToken(string nextToken)
        {
            this.nextTokenField = nextToken;
            return this;
        }

        /// <summary>
        /// Checks if NextToken property is set
        /// </summary>
        /// <returns>true if NextToken property is set</returns>
        public bool IsSetNextToken()
        {
            return this.nextTokenField != null;
        }
    }
}
