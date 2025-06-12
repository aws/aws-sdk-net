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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
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
namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Represents the details of a configuration set. Configuration sets enable you to publish
    /// email sending events. For information about using configuration sets, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/monitor-sending-activity.html">Amazon
    /// SES Developer Guide</a>.
    /// </summary>
    public partial class DescribeConfigurationSetResponse : AmazonWebServiceResponse
    {
        private ConfigurationSet _configurationSet;
        private DeliveryOptions _deliveryOptions;
        private List<EventDestination> _eventDestinations = AWSConfigs.InitializeCollections ? new List<EventDestination>() : null;
        private ReputationOptions _reputationOptions;
        private TrackingOptions _trackingOptions;

        /// <summary>
        /// Gets and sets the property ConfigurationSet. 
        /// <para>
        /// The configuration set object associated with the specified configuration set.
        /// </para>
        /// </summary>
        public ConfigurationSet ConfigurationSet
        {
            get { return this._configurationSet; }
            set { this._configurationSet = value; }
        }

        // Check to see if ConfigurationSet property is set
        internal bool IsSetConfigurationSet()
        {
            return this._configurationSet != null;
        }

        /// <summary>
        /// Gets and sets the property DeliveryOptions.
        /// </summary>
        public DeliveryOptions DeliveryOptions
        {
            get { return this._deliveryOptions; }
            set { this._deliveryOptions = value; }
        }

        // Check to see if DeliveryOptions property is set
        internal bool IsSetDeliveryOptions()
        {
            return this._deliveryOptions != null;
        }

        /// <summary>
        /// Gets and sets the property EventDestinations. 
        /// <para>
        /// A list of event destinations associated with the configuration set. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EventDestination> EventDestinations
        {
            get { return this._eventDestinations; }
            set { this._eventDestinations = value; }
        }

        // Check to see if EventDestinations property is set
        internal bool IsSetEventDestinations()
        {
            return this._eventDestinations != null && (this._eventDestinations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReputationOptions. 
        /// <para>
        /// An object that represents the reputation settings for the configuration set. 
        /// </para>
        /// </summary>
        public ReputationOptions ReputationOptions
        {
            get { return this._reputationOptions; }
            set { this._reputationOptions = value; }
        }

        // Check to see if ReputationOptions property is set
        internal bool IsSetReputationOptions()
        {
            return this._reputationOptions != null;
        }

        /// <summary>
        /// Gets and sets the property TrackingOptions. 
        /// <para>
        /// The name of the custom open and click tracking domain associated with the configuration
        /// set.
        /// </para>
        /// </summary>
        public TrackingOptions TrackingOptions
        {
            get { return this._trackingOptions; }
            set { this._trackingOptions = value; }
        }

        // Check to see if TrackingOptions property is set
        internal bool IsSetTrackingOptions()
        {
            return this._trackingOptions != null;
        }

    }
}