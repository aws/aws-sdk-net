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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Information about a configuration set.
    /// </summary>
    public partial class GetConfigurationSetResponse : AmazonWebServiceResponse
    {
        private string _configurationSetName;
        private DeliveryOptions _deliveryOptions;
        private ReputationOptions _reputationOptions;
        private SendingOptions _sendingOptions;
        private SuppressionOptions _suppressionOptions;
        private List<Tag> _tags = new List<Tag>();
        private TrackingOptions _trackingOptions;

        /// <summary>
        /// Gets and sets the property ConfigurationSetName. 
        /// <para>
        /// The name of the configuration set.
        /// </para>
        /// </summary>
        public string ConfigurationSetName
        {
            get { return this._configurationSetName; }
            set { this._configurationSetName = value; }
        }

        // Check to see if ConfigurationSetName property is set
        internal bool IsSetConfigurationSetName()
        {
            return this._configurationSetName != null;
        }

        /// <summary>
        /// Gets and sets the property DeliveryOptions. 
        /// <para>
        /// An object that defines the dedicated IP pool that is used to send emails that you
        /// send using the configuration set.
        /// </para>
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
        /// Gets and sets the property ReputationOptions. 
        /// <para>
        /// An object that defines whether or not Amazon SES collects reputation metrics for the
        /// emails that you send that use the configuration set.
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
        /// Gets and sets the property SendingOptions. 
        /// <para>
        /// An object that defines whether or not Amazon SES can send email that you send using
        /// the configuration set.
        /// </para>
        /// </summary>
        public SendingOptions SendingOptions
        {
            get { return this._sendingOptions; }
            set { this._sendingOptions = value; }
        }

        // Check to see if SendingOptions property is set
        internal bool IsSetSendingOptions()
        {
            return this._sendingOptions != null;
        }

        /// <summary>
        /// Gets and sets the property SuppressionOptions. 
        /// <para>
        /// An object that contains information about the suppression list preferences for your
        /// account.
        /// </para>
        /// </summary>
        public SuppressionOptions SuppressionOptions
        {
            get { return this._suppressionOptions; }
            set { this._suppressionOptions = value; }
        }

        // Check to see if SuppressionOptions property is set
        internal bool IsSetSuppressionOptions()
        {
            return this._suppressionOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of objects that define the tags (keys and values) that are associated with
        /// the configuration set.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TrackingOptions. 
        /// <para>
        /// An object that defines the open and click tracking options for emails that you send
        /// using the configuration set.
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