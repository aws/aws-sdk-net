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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
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
namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSubscriber operation.
    /// Creates a subscriber for accounts that are already enabled in Amazon Security Lake.
    /// You can create a subscriber with access to data in the current Amazon Web Services
    /// Region.
    /// </summary>
    public partial class CreateSubscriberRequest : AmazonSecurityLakeRequest
    {
        private List<string> _accessTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<LogSourceResource> _sources = AWSConfigs.InitializeCollections ? new List<LogSourceResource>() : null;
        private string _subscriberDescription;
        private AwsIdentity _subscriberIdentity;
        private string _subscriberName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AccessTypes. 
        /// <para>
        /// The Amazon S3 or Lake Formation access type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AccessTypes
        {
            get { return this._accessTypes; }
            set { this._accessTypes = value; }
        }

        // Check to see if AccessTypes property is set
        internal bool IsSetAccessTypes()
        {
            return this._accessTypes != null && (this._accessTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Sources. 
        /// <para>
        /// The supported Amazon Web Services services from which logs and events are collected.
        /// Security Lake supports log and event collection for natively supported Amazon Web
        /// Services services.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<LogSourceResource> Sources
        {
            get { return this._sources; }
            set { this._sources = value; }
        }

        // Check to see if Sources property is set
        internal bool IsSetSources()
        {
            return this._sources != null && (this._sources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubscriberDescription. 
        /// <para>
        /// The description for your subscriber account in Security Lake.
        /// </para>
        /// </summary>
        public string SubscriberDescription
        {
            get { return this._subscriberDescription; }
            set { this._subscriberDescription = value; }
        }

        // Check to see if SubscriberDescription property is set
        internal bool IsSetSubscriberDescription()
        {
            return this._subscriberDescription != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriberIdentity. 
        /// <para>
        /// The Amazon Web Services identity used to access your data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AwsIdentity SubscriberIdentity
        {
            get { return this._subscriberIdentity; }
            set { this._subscriberIdentity = value; }
        }

        // Check to see if SubscriberIdentity property is set
        internal bool IsSetSubscriberIdentity()
        {
            return this._subscriberIdentity != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriberName. 
        /// <para>
        /// The name of your Security Lake subscriber account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=64)]
        public string SubscriberName
        {
            get { return this._subscriberName; }
            set { this._subscriberName = value; }
        }

        // Check to see if SubscriberName property is set
        internal bool IsSetSubscriberName()
        {
            return this._subscriberName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of objects, one for each tag to associate with the subscriber. For each tag,
        /// you must specify both a tag key and a tag value. A tag value cannot be null, but it
        /// can be an empty string.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}