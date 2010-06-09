/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2009-11-30
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describe Spot Datafeed Result
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2009-11-30/", IsNullable = false)]
    public class DescribeSpotDatafeedSubscriptionResult
    {
        private SpotDatafeedSubscription spotDatafeedSubscriptionField;

        /// <summary>
        /// Gets and sets the SpotDatafeedSubscription property.
        /// The description of the Spot Datafeed subsciption.
        /// </summary>
        [XmlElementAttribute(ElementName = "SpotDatafeedSubscription")]
        public SpotDatafeedSubscription SpotDatafeedSubscription
        {
            get { return this.spotDatafeedSubscriptionField ; }
            set { this.spotDatafeedSubscriptionField = value; }
        }

        /// <summary>
        /// Sets the SpotDatafeedSubscription property
        /// </summary>
        /// <param name="spotDatafeedSubscription">The description of the Spot Datafeed subsciption.</param>
        /// <returns>this instance</returns>
        public DescribeSpotDatafeedSubscriptionResult WithSpotDatafeedSubscription(SpotDatafeedSubscription spotDatafeedSubscription)
        {
            this.spotDatafeedSubscriptionField = spotDatafeedSubscription;
            return this;
        }

        /// <summary>
        /// Checks if SpotDatafeedSubscription property is set
        /// </summary>
        /// <returns>true if SpotDatafeedSubscription property is set</returns>
        public bool IsSetSpotDatafeedSubscription()
        {
            return this.spotDatafeedSubscriptionField != null;
        }

    }
}
